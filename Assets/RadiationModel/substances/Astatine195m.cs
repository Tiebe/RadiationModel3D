using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine195m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine195m";
        public override double halfLife { get; } = 0.143d;
        public override double atomicWeight { get; } = 194.99631d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new List<RadioactiveSubstance> { new AlphaParticle(8393047.4), new Bismuth191() } },
            { 0.12d, new List<RadioactiveSubstance> { new GammaParticle(0.04275), new Astatine195() } },

        };
    }
}
    
    