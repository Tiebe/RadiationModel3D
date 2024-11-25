using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium97";
        public override double halfLife { get; } = 60296.4d;
        public override double atomicWeight { get; } = 96.91096d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium97() }, { 1.0d, new BetaParticle(-1, 1333155.0) }, { 0.0006516299999999999d, new GammaParticle(111600.0, 0.01111) }, { 0.00031650600000000004d, new GammaParticle(182900.0, 0.00678) }, { 0.00028857899999999996d, new GammaParticle(202500.0, 0.00612) }, { 0.0016756199999999998d, new GammaParticle(218900.0, 0.00566) }, { 0.011450070000000001d, new GammaParticle(254170.0, 0.00488) }, { 0.00232725d, new GammaParticle(272400.0, 0.00455) }, { 0.0008378099999999999d, new GammaParticle(294800.0, 0.00421) }, { 0.0006609389999999999d, new GammaParticle(297200.0, 0.00417) }, { 0.00027927000000000003d, new GammaParticle(305100.0, 0.00406) }, { 0.001433586d, new GammaParticle(330430.0, 0.00375) }, { 0.02094525d, new GammaParticle(355400.0, 0.00349) }, { 0.002448267d, new GammaParticle(400420.0, 0.0031) }, { 0.0006516299999999999d, new GammaParticle(410000.0, 0.00302) }, { 0.0007447199999999999d, new GammaParticle(473500.0, 0.00262) }, { 0.050268600000000004d, new GammaParticle(507640.0, 0.00244) }, { 0.00549231d, new GammaParticle(513410.0, 0.00241) }, { 0.00027927000000000003d, new GammaParticle(558000.0, 0.00222) }, { 0.0018618d, new GammaParticle(600600.0, 0.00206) }, { 0.01377732d, new GammaParticle(602370.0, 0.00206) }, { 0.001833873d, new GammaParticle(690520.0, 0.0018) }, { 0.001005372d, new GammaParticle(699200.0, 0.00177) }, { 0.01014681d, new GammaParticle(703760.0, 0.00176) }, { 0.00031650600000000004d, new GammaParticle(707400.0, 0.00175) }, { 0.9309000000000001d, new GammaParticle(743360.0, 0.00167) }, { 0.00242034d, new GammaParticle(772000.0, 0.00161) }, { 0.0018618d, new GammaParticle(775000.0, 0.0016) }, { 0.00614394d, new GammaParticle(804520.0, 0.00154) }, { 0.0027927000000000004d, new GammaParticle(805600.0, 0.00154) }, { 0.002392413d, new GammaParticle(829790.0, 0.00149) }, { 0.003565347d, new GammaParticle(854890.0, 0.00145) }, { 0.002783391d, new GammaParticle(971340.0, 0.00128) }, { 0.0037236d, new GammaParticle(1018100.0, 0.00122) }, { 0.01014681d, new GammaParticle(1021200.0, 0.00121) }, { 0.0027927000000000004d, new GammaParticle(1026700.0, 0.00121) }, { 0.0009309d, new GammaParticle(1110440.0, 0.00112) }, { 0.02615829d, new GammaParticle(1147970.0, 0.00108) }, { 0.00940209d, new GammaParticle(1276070.0, 0.00097) }, { 0.0065163d, new GammaParticle(1361000.0, 0.00091) }, { 0.0102399d, new GammaParticle(1362680.0, 0.00091) }, { 0.01089153d, new GammaParticle(1750240.0, 0.00071) }, { 0.00307197d, new GammaParticle(1851610.0, 0.00067) }, { 0.000709697667853045d, new GammaParticle(2299.0, 0.5393) }, { 0.003756391571489895d, new GammaParticle(16521.0, 0.07505) }, { 0.007174162665183145d, new GammaParticle(16615.0, 0.07462) }, { 0.001856293254280213d, new GammaParticle(18694.0, 0.06632) }, { 0.002134737242422245d, new GammaParticle(18795.0, 0.06597) }, { 0.0002784439881420319d, new GammaParticle(18951.0, 0.06542) } } },

        };
    }
}
    