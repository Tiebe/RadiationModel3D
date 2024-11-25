using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium142";
        public override double halfLife { get; } = 0.597d;
        public override double atomicWeight { get; } = 141.93928d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium142() }, { 1.0d, new BetaParticle(1, 7375000.0) }, { 0.002241d, new GammaParticle(388800.0, 0.00319) }, { 0.027389999999999998d, new GammaParticle(465000.0, 0.00267) }, { 0.00498d, new GammaParticle(465000.0, 0.00267) }, { 0.249d, new GammaParticle(515300.0, 0.00241) }, { 0.00996d, new GammaParticle(693700.0, 0.00179) }, { 0.024152999999999997d, new GammaParticle(853100.0, 0.00145) }, { 0.0027389999999999997d, new GammaParticle(898400.0, 0.00138) }, { 0.004482d, new GammaParticle(980100.0, 0.00127) }, { 0.003984d, new GammaParticle(1299600.0, 0.00095) }, { 0.001992d, new GammaParticle(1364100.0, 0.00091) }, { 0.023904d, new GammaParticle(1399200.0, 0.00089) }, { 0.0034860000000000004d, new GammaParticle(1587400.0, 0.00078) }, { 0.002241d, new GammaParticle(1764100.0, 0.0007) }, { 0.00498d, new GammaParticle(1799000.0, 0.00069) }, { 0.006723d, new GammaParticle(1828700.0, 0.00068) }, { 0.0057269999999999995d, new GammaParticle(1915000.0, 0.00065) }, { 0.00249d, new GammaParticle(2343600.0, 0.00053) }, { 1.9246d, new GammaParticle(511000.0, 0.00243) }, { 0.00496d, new GammaParticle(6858.0, 0.18079) }, { 0.00747d, new GammaParticle(42308.0, 0.02931) }, { 0.01344d, new GammaParticle(42996.0, 0.02884) }, { 0.00425d, new GammaParticle(48802.0, 0.02541) }, { 0.00536d, new GammaParticle(49326.0, 0.02514) }, { 0.0011200000000000001d, new GammaParticle(49957.0, 0.02482) } } },
            { 2.2000000000000003e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium141() }, { 1.0d, new BetaParticle(1, 472430051.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    