using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine196m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine196m";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 195.99576d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8175047.4), new Bismuth192() } },

        };
    }
}
    
    