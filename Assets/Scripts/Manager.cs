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
    public bool tenSecMode;
    
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
        
        counter.text = hits.ToString();
        
        if (!tenSecMode)
        {
            return;
        }

        if (timer > 0)
        {
            timer -= Time.deltaTime;
            return;
        }
        
        timeSpent += 10;
        sb.AppendLine(timeSpent.ToString() + "," + hits.ToString());
        hits = 0;
        timer += 10f;
        
        if (timeSpent >= 270)
        {
            var folder = Application.streamingAssetsPath;
            var filepath = Path.Combine(folder, "VervalBetaData.csv");

            using var writer = new StreamWriter(filepath, false);
            writer.Write(sb.ToString());
            
            Debug.Log("Written file to: " + filepath);

            emitter.emitting = false;
        }
    }
}
