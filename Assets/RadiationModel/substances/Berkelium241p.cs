using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium241p : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium241p";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 241.06015d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    