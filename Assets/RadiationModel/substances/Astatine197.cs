using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine197 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine197";
        public override double halfLife { get; } = 0.388d;
        public override double atomicWeight { get; } = 196.99318d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.961d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth193() }, { 1.0d, new AlphaParticle(8127002.09) } } },
            { 0.039d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth197() }, { 1.0d, new BetaParticle(1, 6666000.0) } } },

        };
    }
}
    