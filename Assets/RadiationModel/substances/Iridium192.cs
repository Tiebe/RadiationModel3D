using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium192 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium192";
        public override double halfLife { get; } = 6378825.6d;
        public override double atomicWeight { get; } = 191.9626d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9523999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum192() }, { 1.0d, new BetaParticle(-1, 726450.0) }, { 0.002d, new GammaParticle(136390.0, 0.00909) }, { 4.3e-05d, new GammaParticle(176980.0, 0.00701) }, { 8e-05d, new GammaParticle(280270.0, 0.00442) }, { 0.2871d, new GammaParticle(295956.5, 0.00419) }, { 0.297d, new GammaParticle(308455.07, 0.00402) }, { 0.8286d, new GammaParticle(316506.18, 0.00392) }, { 0.0067d, new GammaParticle(416468.8, 0.00298) }, { 0.47840000000000005d, new GammaParticle(468068.85, 0.00265) }, { 4.7000000000000004e-05d, new GammaParticle(485450.0, 0.00255) }, { 0.04522d, new GammaParticle(588581.0, 0.00211) }, { 0.00042d, new GammaParticle(593630.0, 0.00209) }, { 3.9e-05d, new GammaParticle(599410.0, 0.00207) }, { 0.08216d, new GammaParticle(604411.05, 0.00205) }, { 0.053399999999999996d, new GammaParticle(612462.15, 0.00202) }, { 1.3e-05d, new GammaParticle(765800.0, 0.00162) }, { 0.00292d, new GammaParticle(884536.5, 0.0014) }, { 0.000531d, new GammaParticle(1061490.0, 0.00117) }, { 1.16e-05d, new GammaParticle(1089960.0, 0.00114) }, { 1.4e-05d, new GammaParticle(1378500.0, 0.0009) }, { 0.039245164989227456d, new GammaParticle(11070.0, 0.112) }, { 0.026542601519743005d, new GammaParticle(65122.0, 0.01904) }, { 0.045371968409817096d, new GammaParticle(66832.0, 0.01855) }, { 0.0152664677999766d, new GammaParticle(75821.0, 0.01635) }, { 0.019632677590769906d, new GammaParticle(76725.0, 0.01616) }, { 0.004366209790793308d, new GammaParticle(77832.0, 0.01593) } } },
            { 0.047599999999999996d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium192() }, { 0.000127d, new GammaParticle(110330.0, 0.01124) }, { 0.00471d, new GammaParticle(201311.2, 0.00616) }, { 0.0331d, new GammaParticle(205794.3, 0.00602) }, { 0.00266d, new GammaParticle(283266.8, 0.00438) }, { 0.000173d, new GammaParticle(329090.0, 0.00377) }, { 0.0072699999999999996d, new GammaParticle(374485.2, 0.00331) }, { 0.0006900000000000001d, new GammaParticle(420510.0, 0.00295) }, { 0.0319d, new GammaParticle(484575.1, 0.00256) }, { 0.00438d, new GammaParticle(489060.0, 0.00254) }, { 5.3e-05d, new GammaParticle(703780.0, 0.00176) }, { 0.01502676758200464d, new GammaParticle(10393.0, 0.1193) }, { 0.011984259258336008d, new GammaParticle(61486.0, 0.02016) }, { 0.020651833979555417d, new GammaParticle(63000.0, 0.01968) }, { 0.006909672865209825d, new GammaParticle(71496.0, 0.01734) }, { 0.008844381267468577d, new GammaParticle(72338.0, 0.01714) }, { 0.001934708402258751d, new GammaParticle(73364.0, 0.0169) } } },

        };
    }
}
    