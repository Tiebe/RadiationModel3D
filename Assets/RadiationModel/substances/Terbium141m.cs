using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium141m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium141m";
        public override double halfLife { get; } = 3.5d;
        public override double atomicWeight { get; } = 140.94145d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium141() }, { 1.0d, new BetaParticle(1, 7693000.0) }, { 0.03024d, new GammaParticle(59300.0, 0.02091) }, { 0.0168d, new GammaParticle(59800.0, 0.02073) }, { 0.01848d, new GammaParticle(85200.0, 0.01455) }, { 0.00336d, new GammaParticle(91500.0, 0.01355) }, { 0.00168d, new GammaParticle(94500.0, 0.01312) }, { 0.07896d, new GammaParticle(113200.0, 0.01095) }, { 0.07896d, new GammaParticle(131600.0, 0.00942) }, { 0.14279999999999998d, new GammaParticle(136700.0, 0.00907) }, { 0.03696d, new GammaParticle(145000.0, 0.00855) }, { 0.0252d, new GammaParticle(173900.0, 0.00713) }, { 0.14784d, new GammaParticle(198400.0, 0.00625) }, { 0.00672d, new GammaParticle(206700.0, 0.006) }, { 0.0084d, new GammaParticle(234500.0, 0.00529) }, { 0.0084d, new GammaParticle(248800.0, 0.00498) }, { 0.1176d, new GammaParticle(258200.0, 0.0048) }, { 0.04872d, new GammaParticle(268300.0, 0.00462) }, { 0.168d, new GammaParticle(293300.0, 0.00423) }, { 0.16296d, new GammaParticle(343600.0, 0.00361) }, { 0.04872d, new GammaParticle(379200.0, 0.00327) }, { 0.01848d, new GammaParticle(389000.0, 0.00319) }, { 0.04704d, new GammaParticle(402900.0, 0.00308) }, { 0.01344d, new GammaParticle(406800.0, 0.00305) }, { 0.01176d, new GammaParticle(426000.0, 0.00291) }, { 0.03696d, new GammaParticle(463400.0, 0.00268) }, { 0.08567999999999999d, new GammaParticle(475400.0, 0.00261) }, { 0.05376d, new GammaParticle(480300.0, 0.00258) }, { 0.06888d, new GammaParticle(492200.0, 0.00252) }, { 0.0672d, new GammaParticle(494300.0, 0.00251) }, { 0.09072d, new GammaParticle(500200.0, 0.00248) }, { 0.04536d, new GammaParticle(517500.0, 0.0024) }, { 0.0252d, new GammaParticle(530900.0, 0.00234) }, { 0.0336d, new GammaParticle(554200.0, 0.00224) }, { 0.03528d, new GammaParticle(585600.0, 0.00212) }, { 0.01344d, new GammaParticle(611800.0, 0.00203) }, { 0.04704d, new GammaParticle(617400.0, 0.00201) }, { 0.01848d, new GammaParticle(636900.0, 0.00195) }, { 1.7956d, new GammaParticle(511000.0, 0.00243) }, { 0.069582084d, new GammaParticle(6858.0, 0.18079) }, { 0.10462038607663433d, new GammaParticle(42308.0, 0.02931) }, { 0.18820001093116448d, new GammaParticle(42996.0, 0.02884) }, { 0.05949145991464861d, new GammaParticle(48802.0, 0.02541) }, { 0.07513771387220118d, new GammaParticle(49326.0, 0.02514) }, { 0.015646253957552585d, new GammaParticle(49957.0, 0.02482) } } },

        };
    }
}
    