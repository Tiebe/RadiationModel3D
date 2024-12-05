using System.IO;
using System.Text;
using RadiationModel;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Manager : MonoBehaviour
{
    public RadiationEmitter emitter;
    public Counter counter;
    public Transform absorber;
    public Transform detector;
    public string FileNameEnd;
    
    [HideInInspector]
    public int hits = 0;
    public float timeScale = 1f; // changes timescale at start (please be careful with this)

    private void Start()
    {
        if (counter == null)
        {
            var go = GameObject.FindWithTag("Counter");
            counter = go.GetComponents<Counter>()[0];
        }
    
        counter.SetText("0");
        
        if (emitter == null)
        {
            emitter = GameObject.FindWithTag("Emitter").GetComponent<RadiationEmitter>();
        }

        if (detector == null)
        {
            detector = GameObject.FindWithTag("Detector").GetComponent<Transform>();
        }

        Time.timeScale = timeScale;
        
        StartOverride();
    }

    protected abstract void StartOverride();
    
    private void Update()
    {
        if (!emitter.emitting)
        {
            return;
        }
        
        RunExperiment();
    }
    
    public void OnHit(RadioactiveSubstance particle)
    {
        hits++;
    }
    
    protected abstract void RunExperiment();

    /**
     * writes output data of an experiment to a csv file
     * <param name="data">StringBuilder containing the data to be written to the file</param>
     * <param name="fileName">file name of the csv file (do not append csvm the function already does that</param>
     */
    protected static void WriteData(StringBuilder data, string fileName)
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
