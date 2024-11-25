using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth213 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth213";
        public override double halfLife { get; } = 2735.4d;
        public override double atomicWeight { get; } = 212.99438d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9786d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium213() }, { 1.0d, new BetaParticle(-1, 711000.0) }, { 0.000149d, new GammaParticle(147660.0, 0.0084) }, { 0.00419d, new GammaParticle(292800.0, 0.00423) }, { 1e-06d, new GammaParticle(402800.0, 0.00308) }, { 0.259d, new GammaParticle(440450.0, 0.00281) }, { 2.5e-05d, new GammaParticle(574900.0, 0.00216) }, { 4.3e-05d, new GammaParticle(600900.0, 0.00206) }, { 2.3e-05d, new GammaParticle(604940.0, 0.00205) }, { 2.29e-05d, new GammaParticle(646030.0, 0.00192) }, { 0.00037400000000000004d, new GammaParticle(659750.0, 0.00188) }, { 0.000114d, new GammaParticle(710820.0, 0.00174) }, { 0.0028899999999999998d, new GammaParticle(807360.0, 0.00154) }, { 6.7e-05d, new GammaParticle(826550.0, 0.0015) }, { 0.000118d, new GammaParticle(867980.0, 0.00143) }, { 4.1e-05d, new GammaParticle(880910.0, 0.00141) }, { 2.9e-06d, new GammaParticle(884600.0, 0.0014) }, { 1.01e-05d, new GammaParticle(886660.0, 0.0014) }, { 3.1e-06d, new GammaParticle(897000.0, 0.00138) }, { 0.00053d, new GammaParticle(1003580.0, 0.00124) }, { 0.00017999999999999998d, new GammaParticle(1045700.0, 0.00119) }, { 0.00252d, new GammaParticle(1100170.0, 0.00113) }, { 0.00052d, new GammaParticle(1119400.0, 0.00111) }, { 3.9e-06d, new GammaParticle(1328200.0, 0.00093) }, { 0.0139209200632099d, new GammaParticle(13292.0, 0.09328) }, { 0.009830852643707163d, new GammaParticle(76862.0, 0.01613) }, { 0.016371111813001105d, new GammaParticle(79290.0, 0.01564) }, { 0.005636120500985303d, new GammaParticle(89837.0, 0.0138) }, { 0.007388953976791732d, new GammaParticle(90941.0, 0.01363) }, { 0.0017528334758064293d, new GammaParticle(92315.0, 0.01343) } } },
            { 0.021400000000000002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium209() }, { 1.0d, new AlphaParticle(7010002.09) }, { 0.00167d, new GammaParticle(323700.0, 0.00383) }, { 0.000167d, new GammaParticle(544900.0, 0.00228) }, { 8.541970508e-05d, new GammaParticle(12148.0, 0.10206) }, { 6.137422732725946e-05d, new GammaParticle(70832.0, 0.0175) }, { 0.00010360267948558314d, new GammaParticle(72874.0, 0.01701) }, { 3.523408110035266e-05d, new GammaParticle(82629.0, 0.015) }, { 4.5698603187157396e-05d, new GammaParticle(83631.0, 0.01483) }, { 1.0464522086804739e-05d, new GammaParticle(84866.0, 0.01461) } } },

        };
    }
}
    