using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium74m : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium74m";
        public override double halfLife { get; } = 9.5d;
        public override double atomicWeight { get; } = 73.92701d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium74() }, { 2.3e-06d, new GammaParticle(3200.0, 0.38745) }, { 0.53d, new GammaParticle(56500.0, 0.02194) }, { 0.0011d, new GammaParticle(59700.0, 0.02077) }, { 0.0046d, new GammaParticle(1127.0, 1.10013) }, { 0.04d, new GammaParticle(9225.0, 0.1344) }, { 0.08d, new GammaParticle(9252.0, 0.13401) }, { 0.017d, new GammaParticle(10306.0, 0.1203) }, { 0.017d, new GammaParticle(10313.0, 0.12022) }, { 0.0001d, new GammaParticle(10365.0, 0.11962) } } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium74() }, { 1.0d, new BetaParticle(-1, 2716225.5) } } },

        };
    }
}
    