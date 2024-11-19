using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine199m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine199m";
        public override double halfLife { get; } = 0.273d;
        public override double atomicWeight { get; } = 198.99079d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99d, new List<RadioactiveSubstance> { new GammaParticle(0.00508, 244000.0), new Astatine199() } },
            { 0.01d, new List<RadioactiveSubstance> { new AlphaParticle(8042047.4), new Bismuth195() } },

        };
    }
}
    
    