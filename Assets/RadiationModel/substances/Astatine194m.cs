using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine194m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine194m";
        public override double halfLife { get; } = 0.323d;
        public override double atomicWeight { get; } = 193.99921d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8451047.4), new Bismuth190() } },
            { 0.083d, new List<RadioactiveSubstance> { new BetaParticle(1, 10265000.0), new Polonium194() } },

        };
    }
}
    
    