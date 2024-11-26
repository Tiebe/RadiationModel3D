using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium206 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium206";
        public override double halfLife { get; } = 760320.0d;
        public override double atomicWeight { get; } = 205.98047d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9455d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead206() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 0.00256d, new GammaParticle(10836.0, 0.11442) }, { 7.29e-05d, new GammaParticle(32532.0, 0.03811) }, { 0.000151d, new GammaParticle(53610.0, 0.02313) }, { 0.0118d, new GammaParticle(59908.0, 0.0207) }, { 0.0008699999999999999d, new GammaParticle(82802.0, 0.01497) }, { 0.00127d, new GammaParticle(117536.0, 0.01055) }, { 0.00035000000000000005d, new GammaParticle(129644.0, 0.00956) }, { 0.0014000000000000002d, new GammaParticle(140486.0, 0.00883) }, { 0.00052d, new GammaParticle(144166.0, 0.0086) }, { 0.001d, new GammaParticle(146180.0, 0.00848) }, { 0.00041d, new GammaParticle(152310.0, 0.00814) }, { 0.0031d, new GammaParticle(170501.0, 0.00727) }, { 0.00096d, new GammaParticle(171340.0, 0.00724) }, { 0.00041d, new GammaParticle(178203.0, 0.00696) }, { 0.00096d, new GammaParticle(180791.0, 0.00686) }, { 0.00039d, new GammaParticle(210670.0, 0.00589) }, { 0.00026d, new GammaParticle(224850.0, 0.00551) }, { 0.008d, new GammaParticle(281923.0, 0.0044) }, { 0.22899999999999998d, new GammaParticle(286410.0, 0.00433) }, { 0.00041d, new GammaParticle(292800.0, 0.00423) }, { 0.0408d, new GammaParticle(311560.0, 0.00398) }, { 0.0011799999999999998d, new GammaParticle(322810.0, 0.00384) }, { 0.00094d, new GammaParticle(324730.0, 0.00382) }, { 0.185d, new GammaParticle(338440.0, 0.00366) }, { 0.00057d, new GammaParticle(343970.0, 0.0036) }, { 0.0038d, new GammaParticle(354870.0, 0.00349) }, { 0.00166d, new GammaParticle(369080.0, 0.00336) }, { 0.0017000000000000001d, new GammaParticle(381220.0, 0.00325) }, { 0.0031d, new GammaParticle(452470.0, 0.00274) }, { 0.00149d, new GammaParticle(457760.0, 0.00271) }, { 0.0173d, new GammaParticle(463380.0, 0.00268) }, { 0.00249d, new GammaParticle(468980.0, 0.00264) }, { 0.23199999999999998d, new GammaParticle(511360.0, 0.00242) }, { 0.151d, new GammaParticle(522470.0, 0.00237) }, { 0.00082d, new GammaParticle(533560.0, 0.00232) }, { 0.00035000000000000005d, new GammaParticle(544390.0, 0.00228) }, { 0.015d, new GammaParticle(554640.0, 0.00224) }, { 0.0102d, new GammaParticle(579780.0, 0.00214) }, { 0.00043d, new GammaParticle(591800.0, 0.0021) }, { 0.0033900000000000002d, new GammaParticle(645580.0, 0.00192) }, { 0.00021999999999999998d, new GammaParticle(664080.0, 0.00187) }, { 0.0083d, new GammaParticle(668750.0, 0.00185) }, { 0.014199999999999999d, new GammaParticle(677710.0, 0.00183) }, { 0.00197d, new GammaParticle(693810.0, 0.00179) }, { 0.00046d, new GammaParticle(719700.0, 0.00172) }, { 0.00066d, new GammaParticle(722030.0, 0.00172) }, { 0.00091d, new GammaParticle(727340.0, 0.0017) }, { 0.0001d, new GammaParticle(741500.0, 0.00167) }, { 0.218d, new GammaParticle(807380.0, 0.00154) }, { 0.01d, new GammaParticle(818230.0, 0.00152) }, { 0.001463d, new GammaParticle(826440.0, 0.0015) }, { 0.00096d, new GammaParticle(837240.0, 0.00148) }, { 0.0341d, new GammaParticle(860930.0, 0.00144) }, { 0.00035000000000000005d, new GammaParticle(866220.0, 0.00143) }, { 0.0002d, new GammaParticle(877900.0, 0.00141) }, { 0.0023799999999999997d, new GammaParticle(902530.0, 0.00137) }, { 7.000000000000001e-05d, new GammaParticle(944100.0, 0.00131) }, { 0.00041d, new GammaParticle(947240.0, 0.00131) }, { 7.2e-05d, new GammaParticle(969400.0, 0.00128) }, { 0.0681d, new GammaParticle(980230.0, 0.00126) }, { 0.029500000000000002d, new GammaParticle(1007150.0, 0.00123) }, { 0.0009d, new GammaParticle(1008870.0, 0.00123) }, { 0.00188d, new GammaParticle(1012230.0, 0.00122) }, { 0.0034999999999999996d, new GammaParticle(1017930.0, 0.00122) }, { 0.317d, new GammaParticle(1032260.0, 0.0012) }, { 0.0027700000000000003d, new GammaParticle(1043170.0, 0.00119) }, { 0.0028399999999999996d, new GammaParticle(1114490.0, 0.00111) }, { 0.00454d, new GammaParticle(1190920.0, 0.00104) }, { 0.00039d, new GammaParticle(1193890.0, 0.00104) }, { 0.0062d, new GammaParticle(1318680.0, 0.00094) }, { 0.0005600000000000001d, new GammaParticle(1452740.0, 0.00085) }, { 0.00242d, new GammaParticle(1496900.0, 0.00083) }, { 0.6436196410771946d, new GammaParticle(12904.0, 0.09608) }, { 0.27304974800803183d, new GammaParticle(74815.0, 0.01657) }, { 0.4568341107713432d, new GammaParticle(77108.0, 0.01608) }, { 0.15648352255606815d, new GammaParticle(87388.0, 0.01419) }, { 0.204367480458225d, new GammaParticle(88458.0, 0.01402) }, { 0.047883957902156854d, new GammaParticle(89784.0, 0.01381) } } },
            { 0.0545d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead202() }, { 1.0d, new AlphaParticle(6349002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    