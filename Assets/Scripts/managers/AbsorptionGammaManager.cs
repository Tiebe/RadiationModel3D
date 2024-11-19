using System.Text;
using UnityEngine;

namespace managers
{
    public class AbsorptionGammaManager : Manager
    {
        private float[] thicknesses = { 0.3f, 0.6f, 0.9f, 1.2f, 1.5f, 1.8f, 2.1f }; // in cm because im stupid
        private StringBuilder sb = new();
        
        private float timer;
        private int iteration;
        
        protected override void StartOverride()
        {
            
        }

        protected override void RunExperiment()
        {
            if (emitter.resetter)
            {
                return;
            }

            if (sb.Length == 0)
            {
                sb.AppendLine("d(cm), I (pulsen/10s)");
            }

            counter.text = hits.ToString();

            absorber.localScale = new Vector3(thicknesses[iteration / 3] * 0.01f, 0.15f, 0.15f);

            if (timer > 0)
            {
                timer -= Time.deltaTime;
                return;
            }

            sb.AppendLine(thicknesses[iteration / 3].ToString() + "," + hits.ToString());
            Debug.Log(thicknesses[iteration / 3].ToString() + "," + hits.ToString() + ", " + iteration);
            hits = 0;
            timer += 10f;
            iteration += 1;

            if (iteration >= thicknesses.Length * 3)
            {
                WriteData(sb, "AbsorbtieGammaData");
                emitter.emitting = false;
            }

            emitter.resetter = true;
            Debug.Log("Resetting");
            
        }
    }
}