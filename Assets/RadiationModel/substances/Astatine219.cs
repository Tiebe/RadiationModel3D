
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

            { 0.9359999999999999d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bismuth215() } },

            { 0.064d, new List<RadioactiveSubstance> { new BetaParticle(), new Radon219() } },

        };
    }
}
    
    