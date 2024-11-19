using System;
using System.IO;
using System.Text;
using MathNet.Numerics;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public RadiationEmitter emitter;
    public TextMeshProUGUI counter;
    public Transform detector;
    private Transform emitterTransform;
    public int hits = 0;
    public Modes currentMode = Modes.Default; // should in most cases be Modes.Default
    public int experimentDuration = 270; //270 is the total duration of the decay beta experiment
    private float[] DistanceList = { 0.2f, 0.25f, 0.3f, 0.4f, 0.5f, 0.6f }; // in meters
    public float tScale = 1f; // changes timescale at start (please be carefull with this)
    
    public enum Modes
    {
        Default,
        TenSecondInterval,
        Distance,
    }
    
    private float timer;
    private int iteration = 0;
    private StringBuilder sb = new System.Text.StringBuilder();

    private void Start()
    {
        if (counter == null)
        {
            var go = GameObject.FindWithTag("Counter");
            counter = go.GetComponents<TextMeshProUGUI>()[0];
        }
    
        counter.text = "0";
        
        if (emitter == null)
        {
            emitter = GameObject.FindWithTag("Emitter").GetComponent<RadiationEmitter>();
            emitterTransform = emitter.transform;
        }

        if (detector == null)
        {
            detector = GameObject.FindWithTag("Detector").GetComponent<Transform>();
        }

        Time.timeScale = tScale;
    }
    
    private void Update()
    {
        if (!emitter.emitting)
        {
            return;
        }

        switch (currentMode)
        {
            case Modes.Default:
                counter.text = hits.ToString();
                break;
            
            case Modes.TenSecondInterval:
                if (sb.Length == 0)
                {
                    sb.AppendLine("t(s), hits");
                    timer += 10f;
                }
                
                counter.text = hits.ToString();

                if (timer > 0)
                {
                    timer -= Time.deltaTime;
                    return;
                }

                iteration+= 1;
                sb.AppendLine((iteration*10).ToString() + "," + hits.ToString());
                hits = 0;
                timer += 10f;

                if (iteration*10 >= experimentDuration)
                {
                    WriteData(sb, "VarvalBetaData");
                    emitter.emitting = false;
                }
                break;
            case Modes.Distance:

                if (sb.Length == 0)
                {
                    sb.AppendLine("d(m), hits/60s");
                    timer += 60f;
                }
                
                counter.text = hits.ToString();
                
                var distance = DistanceList[iteration/3]; // dividing int's in this manner floors automatically
                if (Vector3.Distance(emitterTransform.position, detector.position).Round(2) != distance.Round(2)) // floating point error :(
                {
                    detector.position = new Vector3(0f, emitterTransform.position.y + distance, 0);
                    Debug.Log("moved detector");
                }
                
                if (timer > 0)
                {
                    timer -= Time.deltaTime;
                    return;
                }
                
                sb.AppendLine(distance.ToString() + "," + hits.ToString());
                hits = 0;
                timer += 60f;
                iteration++;

                if (iteration >= DistanceList.Length * 3)
                {
                    WriteData(sb, "AfstandBetaData");
                    emitter.emitting = false;
                }
                
                break;
        }
    }

    /**
     * writes output data of an experiment to a csv file
     * <param name="data">StringBuilder containing the data to be written to the file</param>
     * <param name="fileName">file name of the csv file (do not append csvm the function already does that</param>
     */
    private void WriteData(StringBuilder data, string fileName)
    {
        var documentFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
        var folder = Path.Combine(documentFolder, "RadiationModel3D", "Output");
        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
        }
        
        var filepath = Path.Combine(folder, fileName + ".csv");
        
        using var writer = new StreamWriter(filepath, false);
        writer.Write(data.ToString());
        
        Debug.Log("Written file to: " + filepath);
    }
}
