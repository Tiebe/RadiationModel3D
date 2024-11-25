using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium238m : RadioactiveSubstance
    {
        public override string name { get; } = "Americium238m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 238.05466d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    