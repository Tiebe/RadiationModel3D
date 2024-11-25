using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium147m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium147m";
        public override double halfLife { get; } = 109.8d;
        public override double atomicWeight { get; } = 146.92411d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium147() }, { 1.0d, new BetaParticle(1, 3426300.0) }, { 0.0006d, new GammaParticle(442600.0, 0.0028) }, { 0.0044d, new GammaParticle(704500.0, 0.00176) }, { 0.0026d, new GammaParticle(927300.0, 0.00134) }, { 0.0014000000000000002d, new GammaParticle(947100.0, 0.00131) }, { 0.011000000000000001d, new GammaParticle(997200.0, 0.00124) }, { 0.0024d, new GammaParticle(1027300.0, 0.00121) }, { 0.0017000000000000001d, new GammaParticle(1116300.0, 0.00111) }, { 0.0008d, new GammaParticle(1125700.0, 0.0011) }, { 0.0031d, new GammaParticle(1260700.0, 0.00098) }, { 0.0015d, new GammaParticle(1362500.0, 0.00091) }, { 0.0016d, new GammaParticle(1388800.0, 0.00089) }, { 0.79d, new GammaParticle(1397300.0, 0.00089) }, { 0.0013d, new GammaParticle(1407500.0, 0.00088) }, { 0.0032d, new GammaParticle(1574200.0, 0.00079) }, { 0.009000000000000001d, new GammaParticle(1608700.0, 0.00077) }, { 0.0005d, new GammaParticle(1628300.0, 0.00076) }, { 0.0092d, new GammaParticle(1642700.0, 0.00075) }, { 0.149d, new GammaParticle(1798200.0, 0.00069) }, { 0.0024d, new GammaParticle(1807100.0, 0.00069) }, { 0.0073d, new GammaParticle(1944100.0, 0.00064) }, { 0.0062d, new GammaParticle(2078400.0, 0.0006) }, { 0.0036d, new GammaParticle(2875200.0, 0.00043) }, { 0.0058d, new GammaParticle(2971400.0, 0.00042) }, { 0.006500000000000001d, new GammaParticle(3005400.0, 0.00041) }, { 0.0067d, new GammaParticle(3204600.0, 0.00039) }, { 0.0067d, new GammaParticle(3322200.0, 0.00037) }, { 0.6221124d, new GammaParticle(511000.0, 0.00243) }, { 0.102d, new GammaParticle(6858.0, 0.18079) }, { 0.1537d, new GammaParticle(42308.0, 0.02931) }, { 0.27649999999999997d, new GammaParticle(42996.0, 0.02884) }, { 0.0874d, new GammaParticle(48802.0, 0.02541) }, { 0.1104d, new GammaParticle(49326.0, 0.02514) }, { 0.023d, new GammaParticle(49957.0, 0.02482) } } },

        };
    }
}
    