using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium221";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 221.03857d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    