using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium245p : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium245p";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 245.06641d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    