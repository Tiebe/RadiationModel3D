using System.Globalization;
using System.Text;
using UnityEngine;

namespace managers
{
    public class IntervalManager : Manager
    {
        public int experimentDuration = 270; //270 is the total duration of the decay beta experiment
        private StringBuilder sb = new();
        public float interval = 10f;
        
        private float timer;
        private int iteration;

        protected override void StartOverride()
        {
            
        }

        protected override void RunExperiment()
        {
            if (sb.Length == 0)
            {
                sb.AppendLine("t(s), hits");
                timer += interval;
            }

            counter.SetText(hits.ToString());

            if (timer > 0)
            {
                timer -= Time.deltaTime;
                return;
            }

            iteration += 1;
            sb.AppendLine((iteration * interval).ToString(CultureInfo.InvariantCulture) + "," + hits);
            hits = 0;
            timer += interval;

            if (iteration * interval >= experimentDuration)
            {
                emitter.emitting = false;
                WriteData(sb, "VervalBetaData" + FileNameEnd);
            }
        }
    }
}