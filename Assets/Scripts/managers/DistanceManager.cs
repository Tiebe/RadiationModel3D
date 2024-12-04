using System.Text;
using MathNet.Numerics;
using UnityEngine;

namespace managers
{
    public class DistanceManager : Manager
    {
        private float[] DistanceList = { 0.2f, 0.25f, 0.3f, 0.4f, 0.5f, 0.6f }; // in meters
        private StringBuilder sb = new();
        
        private float timer;
        private int iteration;
        
        private Transform emitterTransform;
        
        protected override void StartOverride()
        {
            emitterTransform = emitter.transform;
        }

        protected override void RunExperiment()
        {
            if (sb.Length == 0)
            {
                sb.AppendLine("d(m), hits/60s");
                timer += 60f;
            }

            counter.SetText(hits.ToString());

            var distance = DistanceList[iteration / 3]; // dividing int's in this manner floors automatically
            if (Vector3.Distance(emitterTransform.position, detector.position).Round(2) !=
                distance.Round(2)) // floating point error :(
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
            
        }
    }
}