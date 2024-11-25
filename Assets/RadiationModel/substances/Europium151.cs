using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium151";
        public override double halfLife { get; } = 5.36467741568064e+25d;
        public override double atomicWeight { get; } = 150.91986d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    