using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium160";
        public override double halfLife { get; } = 6246720.0d;
        public override double atomicWeight { get; } = 159.92717d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium160() }, { 1.0d, new BetaParticle(-1, 917950.0) }, { 0.13153700000000002d, new GammaParticle(86787.7, 0.01429) }, { 0.0005658799999999999d, new GammaParticle(93919.0, 0.0132) }, { 6.170499999999999e-05d, new GammaParticle(176490.0, 0.00702) }, { 0.0518322d, new GammaParticle(197034.1, 0.00629) }, { 0.0401835d, new GammaParticle(215645.2, 0.00575) }, { 0.00080668d, new GammaParticle(230628.0, 0.00538) }, { 6.02e-05d, new GammaParticle(237640.0, 0.00522) }, { 2.107e-05d, new GammaParticle(239700.0, 0.00517) }, { 7.525e-05d, new GammaParticle(242500.0, 0.00511) }, { 0.00020768999999999999d, new GammaParticle(246489.0, 0.00503) }, { 9.331000000000001e-05d, new GammaParticle(297300.0, 0.00417) }, { 0.261268d, new GammaParticle(298578.3, 0.00415) }, { 0.00862967d, new GammaParticle(309561.0, 0.00401) }, { 0.00339227d, new GammaParticle(337320.0, 0.00368) }, { 0.00014448d, new GammaParticle(349920.0, 0.00354) }, { 0.00014146999999999999d, new GammaParticle(379410.0, 0.00327) }, { 0.0133644d, new GammaParticle(392514.0, 0.00316) }, { 0.00023176999999999998d, new GammaParticle(432660.0, 0.00287) }, { 0.00084581d, new GammaParticle(486060.0, 0.00255) }, { 0.0059597999999999995d, new GammaParticle(682310.0, 0.00182) }, { 9.933000000000001e-05d, new GammaParticle(707600.0, 0.00175) }, { 0.0214011d, new GammaParticle(765280.0, 0.00162) }, { 0.00217623d, new GammaParticle(872030.0, 0.00142) }, { 0.301d, new GammaParticle(879378.0, 0.00141) }, { 0.09812599999999999d, new GammaParticle(962311.0, 0.00129) }, { 0.251034d, new GammaParticle(966166.0, 0.00128) }, { 0.010384500000000001d, new GammaParticle(1002880.0, 0.00124) }, { 0.00039129999999999997d, new GammaParticle(1005000.0, 0.00123) }, { 0.0009993200000000002d, new GammaParticle(1069090.0, 0.00116) }, { 0.0058153200000000006d, new GammaParticle(1102600.0, 0.00112) }, { 0.015652d, new GammaParticle(1115120.0, 0.00111) }, { 0.148694d, new GammaParticle(1177954.0, 0.00105) }, { 0.023839199999999998d, new GammaParticle(1199890.0, 0.00103) }, { 0.00105952d, new GammaParticle(1251270.0, 0.00099) }, { 0.0744373d, new GammaParticle(1271873.0, 0.00097) }, { 0.00015351d, new GammaParticle(1285580.0, 0.00096) }, { 5.4481e-05d, new GammaParticle(1299300.0, 0.00095) }, { 0.0286251d, new GammaParticle(1312140.0, 0.00094) }, { 5.719e-06d, new GammaParticle(1468600.0, 0.00084) }, { 4.816e-06d, new GammaParticle(1556600.0, 0.0008) }, { 0.09849442673443011d, new GammaParticle(7384.0, 0.16791) }, { 0.05961106731198338d, new GammaParticle(45207.0, 0.02743) }, { 0.10652442335951283d, new GammaParticle(45998.0, 0.02695) }, { 0.034202814508084226d, new GammaParticle(52220.0, 0.02374) }, { 0.04309554628018612d, new GammaParticle(52791.0, 0.02349) }, { 0.008892731772101899d, new GammaParticle(53478.0, 0.02318) } } },

        };
    }
}
    