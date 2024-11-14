using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine197 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine197";
        public override double halfLife { get; } = 0.3882d;
        public override double atomicWeight { get; } = 196.99318d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.961d, new List<RadioactiveSubstance> { new AlphaParticle(8125047.4), new Bismuth193() } },
            { 0.039d, new List<RadioactiveSubstance> { new BetaParticle(1, 7038000.0), new Polonium197() } },

        };
    }
}
    
    