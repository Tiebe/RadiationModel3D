using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine143 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine143";
        public override double halfLife { get; } = 0.13d;
        public override double atomicWeight { get; } = 142.94547d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    