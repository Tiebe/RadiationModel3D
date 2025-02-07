using System.IO;
using System.Text;
using RadiationModel;
using TMPro;
using UnityEngine;

public abstract class Manager : MonoBehaviour
{
    public RadiationEmitter emitter;
    public Counter counter;
    public GeigerTeller geigerTeller;
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

        if (geigerTeller == null)
        {
            geigerTeller = GameObject.FindWithTag("Detector").GetComponent<GeigerTeller>();
        }
        
        geigerTeller.manager = this;
        
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
     * <param name="fileName">file name of the csv file (do not append csv the function already does that)</param>
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

        while (true)
        {
            try
            {
                using var writer = new StreamWriter(filepath, false);
                writer.Write(data.ToString());
                break;
            }
            catch
            {
                if (!NativeWinAlert.Error("Data kan niet opgeslagen worden, aub excel sluiten \n druk op ok om het opnieuw te proberen", "file write error")) break;
            }
        }

        Debug.Log("Written file to: " + filepath);
    }
}
