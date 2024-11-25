using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth197 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth197";
        public override double halfLife { get; } = 559.8d;
        public override double atomicWeight { get; } = 196.97887d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium197() }, { 1.0d, new BetaParticle(1, 4333500.0) } } },
            { 1e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium193() }, { 1.0d, new AlphaParticle(6387002.09) } } },

        };
    }
}
    