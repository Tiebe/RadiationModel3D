using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium166";
        public override double halfLife { get; } = 25.1d;
        public override double atomicWeight { get; } = 165.93794d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium166() }, { 1.0d, new BetaParticle(-1, 2387849.99999) }, { 0.0858d, new GammaParticle(76580.0, 0.01619) }, { 0.0338d, new GammaParticle(101290.0, 0.01224) }, { 0.044199999999999996d, new GammaParticle(166040.0, 0.00747) }, { 0.26d, new GammaParticle(172750.0, 0.00718) }, { 0.065d, new GammaParticle(177130.0, 0.007) }, { 0.0702d, new GammaParticle(238200.0, 0.00521) }, { 0.16899999999999998d, new GammaParticle(780500.0, 0.00159) }, { 0.059800000000000006d, new GammaParticle(851800.0, 0.00146) }, { 0.1924d, new GammaParticle(857000.0, 0.00145) }, { 0.2522d, new GammaParticle(1039800.0, 0.00119) }, { 0.109243717745344d, new GammaParticle(7384.0, 0.16791) }, { 0.057930878566562566d, new GammaParticle(45207.0, 0.02743) }, { 0.10352194168435055d, new GammaParticle(45998.0, 0.02695) }, { 0.033238779026259414d, new GammaParticle(52220.0, 0.02374) }, { 0.04188086157308686d, new GammaParticle(52791.0, 0.02349) }, { 0.008642082546827447d, new GammaParticle(53478.0, 0.02318) } } },

        };
    }
}
    