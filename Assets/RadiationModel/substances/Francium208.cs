using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium208 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium208";
        public override double halfLife { get; } = 59.1d;
        public override double atomicWeight { get; } = 207.99714d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine204() }, { 1.0d, new AlphaParticle(7807002.09) } } },
            { 0.11d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine208() }, { 1.0d, new BetaParticle(1, 4902500.0) }, { 0.0016d, new GammaParticle(88900.0, 0.01395) }, { 0.0031d, new GammaParticle(161600.0, 0.00767) }, { 0.0022d, new GammaParticle(163700.0, 0.00757) }, { 0.0008d, new GammaParticle(225500.0, 0.0055) }, { 0.001d, new GammaParticle(298700.0, 0.00415) }, { 0.057d, new GammaParticle(325200.0, 0.00381) }, { 0.013000000000000001d, new GammaParticle(335000.0, 0.0037) }, { 0.0052d, new GammaParticle(389300.0, 0.00318) }, { 0.0022d, new GammaParticle(389300.0, 0.00318) }, { 0.0060999999999999995d, new GammaParticle(469800.0, 0.00264) }, { 0.003d, new GammaParticle(491900.0, 0.00252) }, { 0.033d, new GammaParticle(553100.0, 0.00224) }, { 0.11d, new GammaParticle(635800.0, 0.00195) }, { 0.006999999999999999d, new GammaParticle(636300.0, 0.00195) }, { 0.0014000000000000002d, new GammaParticle(671600.0, 0.00185) }, { 0.004d, new GammaParticle(716800.0, 0.00173) }, { 0.0070999999999999995d, new GammaParticle(719600.0, 0.00172) }, { 0.07400000000000001d, new GammaParticle(778500.0, 0.00159) }, { 0.0018d, new GammaParticle(887300.0, 0.0014) }, { 0.005d, new GammaParticle(942500.0, 0.00132) }, { 0.0044d, new GammaParticle(990100.0, 0.00125) }, { 0.06932d, new GammaParticle(511000.0, 0.00243) }, { 0.04d, new GammaParticle(14088.0, 0.08801) }, { 0.021d, new GammaParticle(81070.0, 0.01529) }, { 0.034d, new GammaParticle(83789.0, 0.0148) }, { 0.011899999999999999d, new GammaParticle(94878.0, 0.01307) }, { 0.016d, new GammaParticle(96054.0, 0.01291) }, { 0.0038d, new GammaParticle(97530.0, 0.01271) } } },

        };
    }
}
    