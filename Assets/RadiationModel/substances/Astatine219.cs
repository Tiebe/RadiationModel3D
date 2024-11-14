using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine219 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine219";
        public override double halfLife { get; } = 56.0d;
        public override double atomicWeight { get; } = 219.01116d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9359999999999999d, new List<RadioactiveSubstance> { new AlphaParticle(7362047.4), new Bismuth215() } },
            { 0.064d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1566700.0), new Radon219() } },

        };
    }
}
    
    