using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium143";
        public override double halfLife { get; } = 1172448.0d;
        public override double atomicWeight { get; } = 142.91082d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium143() }, { 1.0d, new BetaParticle(-1, 467050.0) }, { 1.2e-08d, new GammaParticle(742100.0, 0.00167) }, { 6.2544384e-12d, new GammaParticle(5870.0, 0.21122) }, { 1.1503016960484819e-11d, new GammaParticle(36848.0, 0.03365) }, { 2.0948856238362444e-11d, new GammaParticle(37362.0, 0.03318) }, { 6.433577407440524e-12d, new GammaParticle(42380.0, 0.02926) }, { 8.087006801152738e-12d, new GammaParticle(42810.0, 0.02896) }, { 1.6534293937122147e-12d, new GammaParticle(43335.0, 0.02861) } } },

        };
    }
}
    