using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium136 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium136";
        public override double halfLife { get; } = 3039.0d;
        public override double atomicWeight { get; } = 135.91498d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium136() }, { 1.0d, new BetaParticle(1, 3654750.0) }, { 0.192d, new GammaParticle(40200.0, 0.03084) }, { 0.014079999999999999d, new GammaParticle(100540.0, 0.01233) }, { 0.32d, new GammaParticle(108900.0, 0.01139) }, { 0.00544d, new GammaParticle(130540.0, 0.0095) }, { 0.00208d, new GammaParticle(139300.0, 0.0089) }, { 0.0128d, new GammaParticle(144280.0, 0.00859) }, { 0.0704d, new GammaParticle(149100.0, 0.00832) }, { 0.0048d, new GammaParticle(184500.0, 0.00672) }, { 0.0014399999999999999d, new GammaParticle(204300.0, 0.00607) }, { 0.0016d, new GammaParticle(211600.0, 0.00586) }, { 0.000576d, new GammaParticle(219500.0, 0.00565) }, { 0.0016d, new GammaParticle(240400.0, 0.00516) }, { 0.0028799999999999997d, new GammaParticle(252700.0, 0.00491) }, { 0.00208d, new GammaParticle(292400.0, 0.00424) }, { 0.00672d, new GammaParticle(294600.0, 0.00421) }, { 0.0048d, new GammaParticle(336000.0, 0.00369) }, { 0.00768d, new GammaParticle(390300.0, 0.00318) }, { 0.00192d, new GammaParticle(425900.0, 0.00291) }, { 0.00192d, new GammaParticle(436500.0, 0.00284) }, { 0.0128d, new GammaParticle(476700.0, 0.0026) }, { 0.0017599999999999998d, new GammaParticle(488600.0, 0.00254) }, { 0.00256d, new GammaParticle(498700.0, 0.00249) }, { 0.0017599999999999998d, new GammaParticle(523600.0, 0.00237) }, { 0.00048d, new GammaParticle(525900.0, 0.00236) }, { 0.0008d, new GammaParticle(528300.0, 0.00235) }, { 0.00736d, new GammaParticle(534900.0, 0.00232) }, { 0.1056d, new GammaParticle(574800.0, 0.00216) }, { 0.00512d, new GammaParticle(605700.0, 0.00205) }, { 0.00256d, new GammaParticle(632400.0, 0.00196) }, { 0.0048d, new GammaParticle(643900.0, 0.00193) }, { 0.0032d, new GammaParticle(652900.0, 0.0019) }, { 0.0028799999999999997d, new GammaParticle(672400.0, 0.00184) }, { 0.00464d, new GammaParticle(755200.0, 0.00164) }, { 0.00096d, new GammaParticle(841300.0, 0.00147) }, { 0.0016d, new GammaParticle(855500.0, 0.00145) }, { 0.0035199999999999997d, new GammaParticle(900300.0, 0.00138) }, { 0.00256d, new GammaParticle(921900.0, 0.00134) }, { 0.00544d, new GammaParticle(940300.0, 0.00132) }, { 0.00928d, new GammaParticle(972300.0, 0.00128) }, { 0.00256d, new GammaParticle(1013100.0, 0.00122) }, { 0.00272d, new GammaParticle(1021500.0, 0.00121) }, { 0.00256d, new GammaParticle(1031500.0, 0.0012) }, { 0.0032d, new GammaParticle(1041400.0, 0.00119) }, { 0.00208d, new GammaParticle(1062500.0, 0.00117) }, { 0.0028799999999999997d, new GammaParticle(1184000.0, 0.00105) }, { 0.0022400000000000002d, new GammaParticle(1489000.0, 0.00083) }, { 0.092578d, new GammaParticle(511000.0, 0.00243) }, { 0.214d, new GammaParticle(5637.0, 0.21995) }, { 0.299d, new GammaParticle(35551.0, 0.03488) }, { 0.546d, new GammaParticle(36027.0, 0.03441) }, { 0.166d, new GammaParticle(40857.0, 0.03035) }, { 0.209d, new GammaParticle(41266.0, 0.03005) }, { 0.0425d, new GammaParticle(41766.0, 0.02969) } } },

        };
    }
}
    