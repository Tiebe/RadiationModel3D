
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium248p : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium248p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 248.07319d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    