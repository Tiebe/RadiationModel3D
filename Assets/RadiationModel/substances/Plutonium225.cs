using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium225";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 225.03897d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    