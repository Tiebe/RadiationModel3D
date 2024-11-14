using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium283 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium283";
        public override double halfLife { get; } = 0.14d;
        public override double atomicWeight { get; } = 283.17666d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11435047.4), new Roentgenium279() } },

        };
    }
}
    
    