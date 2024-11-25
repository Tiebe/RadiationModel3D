using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver122m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver122m";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 121.92375d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    