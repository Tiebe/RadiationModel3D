using System.Text;
using MathNet.Numerics;
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
            if (absorber == null)
            {
                absorber  = GameObject.FindWithTag("Absorber").GetComponent<Transform>();
            }
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

            counter.SetText(hits.ToString());

            if (absorber.localScale.x.Round(2) != thicknesses[iteration / 3].Round(2))
            {
                absorber.localScale = new Vector3(thicknesses[iteration / 3] * 0.01f, 0.15f, 0.15f);
            }

            if (timer > 0)
            {
                timer -= Time.deltaTime;
                return;
            }

            sb.AppendLine(thicknesses[iteration / 3].ToString() + "," + hits.ToString());
            hits = 0;
            timer += 10f;
            iteration++;

            if (iteration >= thicknesses.Length * 3)
            {
                WriteData(sb, "AbsorbtieGammaData"+FileNameEnd);
                emitter.emitting = false;
                return;
            }

            emitter.resetter = true;
            Debug.Log("Resetting");
            
        }
    }
}