using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium132";
        public override double halfLife { get; } = 6.2d;
        public override double atomicWeight { get; } = 131.93384d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium132() }, { 1.0d, new BetaParticle(1, 6798500.0) }, { 0.78d, new GammaParticle(213100.0, 0.00582) }, { 0.0078000000000000005d, new GammaParticle(294100.0, 0.00422) }, { 0.2028d, new GammaParticle(397000.0, 0.00312) }, { 0.023399999999999997d, new GammaParticle(564500.0, 0.0022) }, { 0.1092d, new GammaParticle(610400.0, 0.00203) }, { 0.1014d, new GammaParticle(823500.0, 0.00151) }, { 0.0546d, new GammaParticle(904500.0, 0.00137) }, { 1.96d, new GammaParticle(511000.0, 0.00243) }, { 0.0169d, new GammaParticle(5870.0, 0.21122) }, { 0.027999999999999997d, new GammaParticle(36848.0, 0.03365) }, { 0.051d, new GammaParticle(37362.0, 0.03318) }, { 0.0158d, new GammaParticle(42380.0, 0.02926) }, { 0.02d, new GammaParticle(42810.0, 0.02896) }, { 0.0040999999999999995d, new GammaParticle(43335.0, 0.02861) } } },
            { 5e-07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium131() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    