using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public RadiationEmitter emitter;
    public TextMeshProUGUI counter;
    public Transform absorber;
    public int hits = 0;
    public Modes currentMode = Modes.Default; // should in most cases be Modes.Default
    public int experimentDuration = 270; //270 is the total duration of the decay beta experiment
    public float[] thicknesses = { 0.3f, 0.5f, 0.6f, 1f, 1.2f, 1.5f, 1.7f, 1.8f, 2.2f }; // in cm because im stupid
    
    public enum Modes
    {
        Default,
        TenSecondInterval,
        AbsorbtieGamma,
    }
    
    private float timer = 10f;
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
        }

        if (absorber == null)
        {
            absorber  = GameObject.FindWithTag("Absorber").GetComponent<Transform>();
        }
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
                }
                
                counter.text = hits.ToString();

                if (timer > 0)
                {
                    timer -= Time.deltaTime;
                    return;
                }

                iteration += 1;
                sb.AppendLine((iteration*10).ToString() + "," + hits.ToString());
                hits = 0;
                timer += 10f;

                if (iteration*10 >= experimentDuration)
                {
                    WriteData(sb, "VarvalBetaData");
                    emitter.emitting = false;
                }
                break;
            case Modes.AbsorbtieGamma:
                if (sb.Length == 0)
                {
                    sb.AppendLine("d(cm), I (pulsen/10s)");
                }
                
                counter.text = hits.ToString();
                
                absorber.localScale = new Vector3(thicknesses[iteration/3] * 0.01f, 0.15f, 0.15f);

                if (timer > 0)
                {
                    timer -= Time.deltaTime;
                    return;
                }
                
                sb.AppendLine(thicknesses[iteration/3].ToString() + "," + hits.ToString());
                Debug.Log(thicknesses[iteration/3].ToString() + "," + hits.ToString() + ", " + iteration);
                hits = 0;
                timer += 10f;
                iteration += 1;
                
                //! reset source (may cause issues im not sure)
                emitter.Emit();

                if (iteration >= thicknesses.Length*3)
                {
                    WriteData(sb, "AbsorbtieGammaData");
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
