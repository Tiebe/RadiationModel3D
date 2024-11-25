using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium250n : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium250n";
        public override double halfLife { get; } = 0.00021d;
        public override double atomicWeight { get; } = 250.07841d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    