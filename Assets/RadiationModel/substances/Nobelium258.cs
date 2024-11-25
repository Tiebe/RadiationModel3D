using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium258";
        public override double halfLife { get; } = 0.0012d;
        public override double atomicWeight { get; } = 258.09821d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    