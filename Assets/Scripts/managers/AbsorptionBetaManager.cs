using System.Linq;
using System.Text;
using MathNet.Numerics;
using UnityEngine;

namespace managers
{
    public class AbsorptionBetaManager : Manager
    {
        private static float[] thicknessesAluminium = { 0.024f, 0.034f, 0.051f, 0.067f, 0.095f, 0.120f, 0.160f, 0.201f, 0.259f, 0.322f, 0.379f, 0.419f };
        private static float[] thicknessesPerspex = { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f, 0.6f, 0.7f, 0.8f, 0.9f, 1.0f, 1.1f, 1.2f };
        private float[] thicknesses = thicknessesAluminium.Concat(thicknessesPerspex).ToArray();
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
            if (sb.Length == 0)
            {
                sb.AppendLine("d(cm), hits");
                absorber.GetComponent<RadiationModelMaterial>().ResetMaterial("Aluminium");
            }
            
            counter.SetText(hits.ToString());

            if (absorber.localScale.x.Round(4) != thicknesses[iteration / 3].Round(4))
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
            
            if (iteration == thicknessesAluminium.Length*3) absorber.GetComponent<RadiationModelMaterial>().ResetMaterial("Perspex");

            if (iteration >= thicknesses.Length * 3)
            {
                WriteData(sb, "AbsorbtieBetaData"+FileNameEnd);
                emitter.emitting = false;
            }
        }
    }
}
