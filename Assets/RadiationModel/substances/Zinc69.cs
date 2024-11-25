using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc69 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc69";
        public override double halfLife { get; } = 3384.0d;
        public override double atomicWeight { get; } = 68.92655d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium69() }, { 1.0d, new BetaParticle(-1, 454950.0) }, { 1.1999999999999999e-05d, new GammaParticle(318400.0, 0.00389) }, { 2.5e-06d, new GammaParticle(871700.0, 0.00142) }, { 7.360474365e-10d, new GammaParticle(1127.0, 1.10013) }, { 6.566967741615372e-09d, new GammaParticle(9225.0, 0.1344) }, { 1.2761305366528122e-08d, new GammaParticle(9252.0, 0.13401) }, { 2.7993333915074627e-09d, new GammaParticle(10306.0, 0.1203) }, { 2.8161293918565075e-09d, new GammaParticle(10313.0, 0.12022) }, { 1.6796000349044777e-11d, new GammaParticle(10365.0, 0.11962) } } },

        };
    }
}
    