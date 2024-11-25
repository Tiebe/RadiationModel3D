using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum125m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum125m";
        public override double halfLife { get; } = 0.39d;
        public override double atomicWeight { get; } = 124.92093d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    