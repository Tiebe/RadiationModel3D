using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead214 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead214";
        public override double halfLife { get; } = 1623.6d;
        public override double atomicWeight { get; } = 213.9998d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth214() }, { 1.0d, new BetaParticle(-1, 509000.0) }, { 0.01073529d, new GammaParticle(53225.6, 0.02329) }, { 6.8175e-05d, new GammaParticle(107220.0, 0.01156) }, { 0.0005454d, new GammaParticle(137500.0, 0.00902) }, { 0.0002727d, new GammaParticle(141300.0, 0.00877) }, { 0.00014544d, new GammaParticle(170070.0, 0.00729) }, { 0.00068175d, new GammaParticle(196200.0, 0.00632) }, { 0.000113625d, new GammaParticle(205680.0, 0.00603) }, { 9.999e-05d, new GammaParticle(216470.0, 0.00573) }, { 0.0726291d, new GammaParticle(241995.0, 0.00512) }, { 0.005313105d, new GammaParticle(258860.0, 0.00479) }, { 0.0033587549999999997d, new GammaParticle(274800.0, 0.00451) }, { 0.1847088d, new GammaParticle(295224.0, 0.0042) }, { 0.00031815d, new GammaParticle(305260.0, 0.00406) }, { 0.0007453799999999999d, new GammaParticle(314320.0, 0.00394) }, { 0.000286335d, new GammaParticle(323830.0, 0.00383) }, { 0.357237d, new GammaParticle(351932.0, 0.00352) }, { 0.002122515d, new GammaParticle(462010.0, 0.00268) }, { 0.00010907999999999999d, new GammaParticle(470600.0, 0.00263) }, { 0.003367845d, new GammaParticle(480430.0, 0.00258) }, { 0.00432684d, new GammaParticle(487110.0, 0.00255) }, { 0.000149985d, new GammaParticle(511000.0, 0.00243) }, { 0.001804365d, new GammaParticle(533660.0, 0.00232) }, { 0.00019088999999999998d, new GammaParticle(538430.0, 0.0023) }, { 0.00049995d, new GammaParticle(543820.0, 0.00228) }, { 0.003685995d, new GammaParticle(580130.0, 0.00214) }, { 0.0005454d, new GammaParticle(766000.0, 0.00162) }, { 0.010589850000000001d, new GammaParticle(785960.0, 0.00158) }, { 0.00580851d, new GammaParticle(839060.0, 0.00148) }, { 0.11137483074964429d, new GammaParticle(12904.0, 0.09608) }, { 0.052212476874370174d, new GammaParticle(74815.0, 0.01657) }, { 0.08735565814684654d, new GammaParticle(77108.0, 0.01608) }, { 0.029922724200567134d, new GammaParticle(87388.0, 0.01419) }, { 0.03907907780594067d, new GammaParticle(88458.0, 0.01402) }, { 0.009156353605373542d, new GammaParticle(89784.0, 0.01381) } } },

        };
    }
}
    