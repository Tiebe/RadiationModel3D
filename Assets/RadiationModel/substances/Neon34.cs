
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon34 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon34";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 34.05673d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    