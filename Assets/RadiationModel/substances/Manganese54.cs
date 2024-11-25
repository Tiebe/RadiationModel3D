using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese54 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese54";
        public override double halfLife { get; } = 26974080.0d;
        public override double atomicWeight { get; } = 53.94036d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium54() }, { 1.0d, new BetaParticle(1, -2830100.0) }, { 0.99976d, new GammaParticle(834848.0, 0.00149) }, { 1.1400000000000001e-08d, new GammaParticle(511000.0, 0.00243) }, { 0.00646147937693664d, new GammaParticle(597.0, 2.07679) }, { 0.07645315653102747d, new GammaParticle(5406.0, 0.22935) }, { 0.15017316152234816d, new GammaParticle(5415.0, 0.22896) }, { 0.030503902409984362d, new GammaParticle(5966.0, 0.20782) }, { 0.030503902409984362d, new GammaParticle(5966.0, 0.20782) } } },
            { 9.3e-07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron54() }, { 1.0d, new BetaParticle(-1, 348200.0) } } },

        };
    }
}
    