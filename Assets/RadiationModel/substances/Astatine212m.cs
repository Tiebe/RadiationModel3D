using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine212m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine212m";
        public override double halfLife { get; } = 0.119d;
        public override double atomicWeight { get; } = 211.99098d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9062002.09), new Bismuth208() } },

        };
    }
}
    
    