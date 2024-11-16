using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium144";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 143.9607d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    