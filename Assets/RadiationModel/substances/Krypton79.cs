using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton79 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton79";
        public override double halfLife { get; } = 126144.0d;
        public override double atomicWeight { get; } = 78.92008d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium79() }, { 1.0d, new BetaParticle(1, 737735.0) }, { 0.002159d, new GammaParticle(44200.0, 0.02805) }, { 0.008509d, new GammaParticle(136090.0, 0.00911) }, { 0.001016d, new GammaParticle(180250.0, 0.00688) }, { 0.007747d, new GammaParticle(208480.0, 0.00595) }, { 0.023749d, new GammaParticle(217070.0, 0.00571) }, { 0.127d, new GammaParticle(261290.0, 0.00475) }, { 0.00010287d, new GammaParticle(280460.0, 0.00442) }, { 0.015366999999999999d, new GammaParticle(299530.0, 0.00414) }, { 0.026035d, new GammaParticle(306470.0, 0.00405) }, { 0.0023622d, new GammaParticle(344710.0, 0.0036) }, { 0.015113000000000001d, new GammaParticle(388970.0, 0.00319) }, { 0.093345d, new GammaParticle(397540.0, 0.00312) }, { 0.00039370000000000003d, new GammaParticle(434500.0, 0.00285) }, { 0.0001651d, new GammaParticle(500700.0, 0.00248) }, { 0.000889d, new GammaParticle(506600.0, 0.00245) }, { 0.002286d, new GammaParticle(523200.0, 0.00237) }, { 0.0039369999999999995d, new GammaParticle(525350.0, 0.00236) }, { 6.604e-05d, new GammaParticle(538500.0, 0.0023) }, { 5.4609999999999994e-05d, new GammaParticle(571100.0, 0.00217) }, { 0.08115299999999999d, new GammaParticle(606090.0, 0.00205) }, { 0.0009525d, new GammaParticle(614890.0, 0.00202) }, { 0.00011429999999999999d, new GammaParticle(650890.0, 0.0019) }, { 6.096e-05d, new GammaParticle(715040.0, 0.00173) }, { 0.00019050000000000002d, new GammaParticle(726560.0, 0.00171) }, { 0.000127d, new GammaParticle(734120.0, 0.00169) }, { 0.0009651999999999999d, new GammaParticle(809170.0, 0.00153) }, { 0.012573d, new GammaParticle(831970.0, 0.00149) }, { 0.00038100000000000005d, new GammaParticle(851130.0, 0.00146) }, { 7.62e-05d, new GammaParticle(871200.0, 0.00142) }, { 0.00011176d, new GammaParticle(895500.0, 0.00138) }, { 7.239e-05d, new GammaParticle(914800.0, 0.00136) }, { 0.0012064999999999999d, new GammaParticle(934840.0, 0.00133) }, { 0.0015113d, new GammaParticle(1025730.0, 0.00121) }, { 0.0006096d, new GammaParticle(1070970.0, 0.00116) }, { 6.604e-05d, new GammaParticle(1076100.0, 0.00115) }, { 0.000127d, new GammaParticle(1104000.0, 0.00112) }, { 0.0006604d, new GammaParticle(1112800.0, 0.00111) }, { 0.0037210999999999998d, new GammaParticle(1115100.0, 0.00111) }, { 0.00041910000000000005d, new GammaParticle(1131560.0, 0.0011) }, { 2.54e-05d, new GammaParticle(1195300.0, 0.00104) }, { 7.62e-05d, new GammaParticle(1239200.0, 0.001) }, { 0.004305300000000001d, new GammaParticle(1332210.0, 0.00093) }, { 1.016e-05d, new GammaParticle(1501600.0, 0.00083) }, { 5.08e-06d, new GammaParticle(1573700.0, 0.00079) }, { 0.14012d, new GammaParticle(511000.0, 0.00243) }, { 0.0206d, new GammaParticle(1535.0, 0.80771) }, { 0.151d, new GammaParticle(11879.0, 0.10437) }, { 0.292d, new GammaParticle(11925.0, 0.10397) }, { 0.0693d, new GammaParticle(13345.0, 0.09291) }, { 0.0746d, new GammaParticle(13377.0, 0.09268) }, { 0.005350000000000001d, new GammaParticle(13469.0, 0.09205) } } },

        };
    }
}
    