using System;
using System.IO;
using System.Text;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public RadiationEmitter emitter;
    public TextMeshProUGUI counter;
    public int hits = 0;
    public Modes currentMode = Modes.Default; // should in most cases be Modes.Default
    public int experimentDuration = 270; //270 is the total duration of the decay beta experiment
    
    public enum Modes
    {
        Default,
        TenSecondInterval,
    }
    
    private float timer = 10f;
    private int timeSpent = 0;
    private StringBuilder sb = new System.Text.StringBuilder();

    private void Start()
    {
        sb.AppendLine("t(s),hits");
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
                counter.text = hits.ToString();

                if (timer > 0)
                {
                    timer -= Time.deltaTime;
                    return;
                }

                timeSpent += 10;
                sb.AppendLine(timeSpent.ToString() + "," + hits.ToString());
                hits = 0;
                timer += 10f;

                if (timeSpent >= experimentDuration)
                {
                    WriteData(sb, "VarvalBetaData");
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
