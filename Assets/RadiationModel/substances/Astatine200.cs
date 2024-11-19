using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine200 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine200";
        public override double halfLife { get; } = 43.2d;
        public override double atomicWeight { get; } = 199.99035d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.52d, new List<RadioactiveSubstance> { new AlphaParticle(7618002.09), new Bismuth196() } },
            { 0.48d, new List<RadioactiveSubstance> { new BetaParticle(1, 7954000.0), new Polonium200() } },

        };
    }
}
    
    