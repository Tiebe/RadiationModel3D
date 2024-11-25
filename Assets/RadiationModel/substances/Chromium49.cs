using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium49 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium49";
        public override double halfLife { get; } = 2538.0d;
        public override double atomicWeight { get; } = 48.95133d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium49() }, { 1.0d, new BetaParticle(1, 1615805.0) }, { 0.163856d, new GammaParticle(62289.0, 0.0199) }, { 0.532d, new GammaParticle(90639.0, 0.01368) }, { 3.1388e-09d, new GammaParticle(133800.0, 0.00927) }, { 0.30324d, new GammaParticle(152928.0, 0.00811) }, { 2.66e-06d, new GammaParticle(595300.0, 0.00208) }, { 2.66e-06d, new GammaParticle(657500.0, 0.00189) }, { 1.064e-05d, new GammaParticle(1021300.0, 0.00121) }, { 1.2768e-06d, new GammaParticle(1027800.0, 0.00121) }, { 2.6599999999999997e-07d, new GammaParticle(1064630.0, 0.00116) }, { 7.98e-07d, new GammaParticle(1155330.0, 0.00107) }, { 0.00045220000000000004d, new GammaParticle(1361610.0, 0.00091) }, { 0.00010108d, new GammaParticle(1423300.0, 0.00087) }, { 7.979999999999999e-05d, new GammaParticle(1508300.0, 0.00082) }, { 0.00026068d, new GammaParticle(1514100.0, 0.00082) }, { 0.00019684d, new GammaParticle(1570600.0, 0.00079) }, { 3.99e-06d, new GammaParticle(2091100.0, 0.00059) }, { 9.2036e-06d, new GammaParticle(2143700.0, 0.00058) }, { 1.6492000000000002e-06d, new GammaParticle(2155700.0, 0.00058) }, { 3.192e-07d, new GammaParticle(2181600.0, 0.00057) }, { 1.9152e-06d, new GammaParticle(2218600.0, 0.00056) }, { 2.2343999999999997e-06d, new GammaParticle(2236200.0, 0.00055) }, { 1.0108e-06d, new GammaParticle(2310600.0, 0.00054) }, { 1.855623448d, new GammaParticle(511000.0, 0.00243) }, { 0.0006900000000000001d, new GammaParticle(536.0, 2.31314) }, { 0.00847d, new GammaParticle(4945.0, 0.25073) }, { 0.0167d, new GammaParticle(4952.0, 0.25037) }, { 0.00335d, new GammaParticle(5444.0, 0.22774) }, { 0.00335d, new GammaParticle(5444.0, 0.22774) } } },

        };
    }
}
    