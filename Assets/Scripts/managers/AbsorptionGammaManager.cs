﻿using System.Globalization;
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

            timer = 10f;
        }

        protected override void RunExperiment()
        {
            if (sb.Length == 0)
            {
                sb.AppendLine("index, d(cm), I (pulsen/10s)");
            }

            counter.SetText(hits.ToString());

            if ((absorber.localScale.x / 100).Round(2) != thicknesses[iteration / 3].Round(2))
            {
                absorber.localScale = new Vector3(thicknesses[iteration / 3] / 100f, 0.15f, 0.15f);
            }

            if (timer > 0)
            {
                timer -= Time.deltaTime;
                return;
            }

            sb.AppendLine(iteration + "," + thicknesses[iteration / 3].ToString(CultureInfo.InvariantCulture) + "," + hits);
            hits = 0;
            timer += 10f;
            iteration += 1;

            if (iteration >= thicknesses.Length * 3)
            {
                emitter.emitting = false;
                WriteData(sb, "AbsorbtieGammaData"+FileNameEnd);
            }
        }
    }
}