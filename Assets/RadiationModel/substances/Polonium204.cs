using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium204 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium204";
        public override double halfLife { get; } = 12668.4d;
        public override double atomicWeight { get; } = 203.98031d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9933d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead204() }, { 1.0d, new BetaParticle(1, 3384400.00001) }, { 0.00047d, new GammaParticle(5550.0, 0.22339) }, { 0.0023499999999999997d, new GammaParticle(9520.0, 0.13024) }, { 0.12300000000000001d, new GammaParticle(63185.0, 0.01962) }, { 0.00404d, new GammaParticle(108055.0, 0.01147) }, { 0.008100000000000001d, new GammaParticle(116057.0, 0.01068) }, { 0.013000000000000001d, new GammaParticle(122582.0, 0.01011) }, { 0.0103d, new GammaParticle(131224.0, 0.00945) }, { 0.111d, new GammaParticle(137023.0, 0.00905) }, { 0.0030499999999999998d, new GammaParticle(152321.0, 0.00814) }, { 0.0322d, new GammaParticle(203561.0, 0.00609) }, { 0.0072d, new GammaParticle(209841.0, 0.00591) }, { 0.0091d, new GammaParticle(229940.0, 0.00539) }, { 0.0208d, new GammaParticle(244724.0, 0.00507) }, { 0.0068000000000000005d, new GammaParticle(253836.0, 0.00488) }, { 0.319d, new GammaParticle(270068.0, 0.00459) }, { 0.0374d, new GammaParticle(304964.0, 0.00407) }, { 0.0063d, new GammaParticle(309800.0, 0.004) }, { 0.049d, new GammaParticle(317016.0, 0.00391) }, { 0.014499999999999999d, new GammaParticle(362140.0, 0.00342) }, { 0.006d, new GammaParticle(419130.0, 0.00296) }, { 0.0216d, new GammaParticle(426820.0, 0.0029) }, { 0.0219d, new GammaParticle(451846.0, 0.00274) }, { 0.011000000000000001d, new GammaParticle(459900.0, 0.0027) }, { 0.152d, new GammaParticle(534920.0, 0.00232) }, { 0.0154d, new GammaParticle(539500.0, 0.0023) }, { 0.0074d, new GammaParticle(582700.0, 0.00213) }, { 0.087d, new GammaParticle(680390.0, 0.00182) }, { 0.0121d, new GammaParticle(751590.0, 0.00165) }, { 0.132d, new GammaParticle(762520.0, 0.00163) }, { 0.0042d, new GammaParticle(768100.0, 0.00161) }, { 0.008100000000000001d, new GammaParticle(817610.0, 0.00152) }, { 0.34299999999999997d, new GammaParticle(883960.0, 0.0014) }, { 0.014199999999999999d, new GammaParticle(905150.0, 0.00137) }, { 0.0059d, new GammaParticle(1003310.0, 0.00124) }, { 0.276d, new GammaParticle(1016290.0, 0.00122) }, { 0.11d, new GammaParticle(1040010.0, 0.00119) }, { 0.0036d, new GammaParticle(1046450.0, 0.00118) }, { 0.0013d, new GammaParticle(1177700.0, 0.00105) }, { 0.00151d, new GammaParticle(1194350.0, 0.00104) }, { 0.001028d, new GammaParticle(1419000.0, 0.00087) }, { 0.0006850000000000001d, new GammaParticle(1461130.0, 0.00085) }, { 2.6e-05d, new GammaParticle(511000.0, 0.00243) }, { 0.8772161021355507d, new GammaParticle(12904.0, 0.09608) }, { 0.4360292085029285d, new GammaParticle(74815.0, 0.01657) }, { 0.7295118094410715d, new GammaParticle(77108.0, 0.01608) }, { 0.24988628256073508d, new GammaParticle(87388.0, 0.01419) }, { 0.32635148502432004d, new GammaParticle(88458.0, 0.01402) }, { 0.07646520246358493d, new GammaParticle(89784.0, 0.01381) } } },
            { 0.0067d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead200() }, { 1.0d, new AlphaParticle(6507002.09) } } },

        };
    }
}
    