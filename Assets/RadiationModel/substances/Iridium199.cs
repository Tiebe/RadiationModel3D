using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium199 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium199";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 198.97381d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    