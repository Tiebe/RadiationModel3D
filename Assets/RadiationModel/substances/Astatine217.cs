using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine217 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine217";
        public override double halfLife { get; } = 0.0326d;
        public override double atomicWeight { get; } = 217.00472d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99992d, new List<RadioactiveSubstance> { new AlphaParticle(8224002.09), new Bismuth213() } },
            { 8e-05d, new List<RadioactiveSubstance> { new BetaParticle(-1, 736000.0), new Radon217() } },

        };
    }
}
    
    