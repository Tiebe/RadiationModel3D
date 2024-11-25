using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium174";
        public override double halfLife { get; } = 324.0d;
        public override double atomicWeight { get; } = 173.94218d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium174() }, { 1.0d, new BetaParticle(-1, 1542260.5) }, { 0.09135d, new GammaParticle(76450.0, 0.01622) }, { 0.000957d, new GammaParticle(94900.0, 0.01306) }, { 0.0006090000000000001d, new GammaParticle(136000.0, 0.00912) }, { 0.000696d, new GammaParticle(138200.0, 0.00897) }, { 0.000261d, new GammaParticle(149500.0, 0.00829) }, { 0.003132d, new GammaParticle(153100.0, 0.0081) }, { 0.6620699999999999d, new GammaParticle(176520.0, 0.00702) }, { 0.002958d, new GammaParticle(223400.0, 0.00555) }, { 0.0008699999999999999d, new GammaParticle(233000.0, 0.00532) }, { 0.857d, new GammaParticle(272730.0, 0.00455) }, { 0.015399000000000001d, new GammaParticle(288000.0, 0.00431) }, { 0.0008699999999999999d, new GammaParticle(315800.0, 0.00393) }, { 0.0026969999999999997d, new GammaParticle(319800.0, 0.00388) }, { 0.00261d, new GammaParticle(348500.0, 0.00356) }, { 0.0034799999999999996d, new GammaParticle(349300.0, 0.00355) }, { 0.00522d, new GammaParticle(358100.0, 0.00346) }, { 0.02697d, new GammaParticle(363700.0, 0.00341) }, { 0.9222d, new GammaParticle(366400.0, 0.00338) }, { 0.003306d, new GammaParticle(387200.0, 0.0032) }, { 0.010875d, new GammaParticle(443630.0, 0.00279) }, { 0.002958d, new GammaParticle(452200.0, 0.00274) }, { 0.005568d, new GammaParticle(458900.0, 0.0027) }, { 0.001392d, new GammaParticle(482400.0, 0.00257) }, { 0.11397d, new GammaParticle(494120.0, 0.00251) }, { 0.002349d, new GammaParticle(502400.0, 0.00247) }, { 0.002784d, new GammaParticle(554500.0, 0.00224) }, { 0.02697d, new GammaParticle(628300.0, 0.00197) }, { 0.016182000000000002d, new GammaParticle(860750.0, 0.00144) }, { 0.87d, new GammaParticle(991840.0, 0.00125) }, { 0.0008699999999999999d, new GammaParticle(1064700.0, 0.00116) }, { 0.001827d, new GammaParticle(1128500.0, 0.0011) }, { 0.001392d, new GammaParticle(1174800.0, 0.00106) }, { 0.001827d, new GammaParticle(1214900.0, 0.00102) }, { 0.017225999999999998d, new GammaParticle(1242100.0, 0.001) }, { 0.021924000000000003d, new GammaParticle(1265180.0, 0.00098) }, { 0.0065249999999999996d, new GammaParticle(1304700.0, 0.00095) }, { 0.0008699999999999999d, new GammaParticle(1316500.0, 0.00094) }, { 0.0008699999999999999d, new GammaParticle(1318200.0, 0.00094) }, { 0.0012180000000000001d, new GammaParticle(1353300.0, 0.00092) }, { 0.0006090000000000001d, new GammaParticle(1358700.0, 0.00091) }, { 0.001566d, new GammaParticle(1448300.0, 0.00086) }, { 0.001566d, new GammaParticle(1530000.0, 0.00081) }, { 0.001827d, new GammaParticle(1631500.0, 0.00076) }, { 0.2336940135031556d, new GammaParticle(8502.0, 0.14583) }, { 0.10550613386957072d, new GammaParticle(51354.0, 0.02414) }, { 0.18597943569464256d, new GammaParticle(52389.0, 0.02367) }, { 0.06104785005702516d, new GammaParticle(59481.0, 0.02084) }, { 0.07698133892190873d, new GammaParticle(60151.0, 0.02061) }, { 0.015933488864883567d, new GammaParticle(60961.0, 0.02034) } } },

        };
    }
}
    