using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium50 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium50";
        public override double halfLife { get; } = 4.10240037669696e+25d;
        public override double atomicWeight { get; } = 49.94604d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    