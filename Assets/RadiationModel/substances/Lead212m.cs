using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead212m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead212m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 211.99333d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    