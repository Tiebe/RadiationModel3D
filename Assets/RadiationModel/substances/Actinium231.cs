using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium231";
        public override double halfLife { get; } = 450.0d;
        public override double atomicWeight { get; } = 231.03839d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium231() }, { 1.0d, new BetaParticle(-1, 973599.99999) }, { 2e-05d, new GammaParticle(19550.0, 0.06342) }, { 0.00058d, new GammaParticle(24600.0, 0.0504) }, { 0.002d, new GammaParticle(26200.0, 0.04732) }, { 0.0018d, new GammaParticle(31300.0, 0.03961) }, { 0.00016d, new GammaParticle(39000.0, 0.03179) }, { 0.0004d, new GammaParticle(41980.0, 0.02953) }, { 0.0028000000000000004d, new GammaParticle(50800.0, 0.02441) }, { 0.0335d, new GammaParticle(143765.0, 0.00862) }, { 0.163d, new GammaParticle(185713.0, 0.00668) }, { 0.027999999999999997d, new GammaParticle(198927.0, 0.00623) }, { 0.17600000000000002d, new GammaParticle(221392.0, 0.0056) }, { 0.0014000000000000002d, new GammaParticle(230243.0, 0.00538) }, { 0.0405d, new GammaParticle(240876.0, 0.00515) }, { 0.0044d, new GammaParticle(247586.0, 0.00501) }, { 0.026099999999999998d, new GammaParticle(272181.0, 0.00456) }, { 0.389d, new GammaParticle(282471.0, 0.00439) }, { 0.305d, new GammaParticle(307063.0, 0.00404) }, { 0.0027d, new GammaParticle(321700.0, 0.00385) }, { 0.0019d, new GammaParticle(333300.0, 0.00372) }, { 0.0054d, new GammaParticle(346100.0, 0.00358) }, { 0.0012d, new GammaParticle(352700.0, 0.00352) }, { 0.151d, new GammaParticle(368934.0, 0.00336) }, { 0.015600000000000001d, new GammaParticle(372221.0, 0.00333) }, { 0.0032d, new GammaParticle(388300.0, 0.00319) }, { 0.033d, new GammaParticle(407899.0, 0.00304) }, { 0.0034999999999999996d, new GammaParticle(512700.0, 0.00242) }, { 0.0023d, new GammaParticle(554700.0, 0.00224) }, { 0.0031d, new GammaParticle(593600.0, 0.00209) }, { 0.45d, new GammaParticle(15784.0, 0.07855) }, { 0.12856205936513695d, new GammaParticle(89954.0, 0.01378) }, { 0.2079619206812309d, new GammaParticle(93347.0, 0.01328) }, { 0.07400003749710708d, new GammaParticle(105566.0, 0.01174) }, { 0.09893805013363216d, new GammaParticle(106894.0, 0.0116) }, { 0.024938012636525085d, new GammaParticle(108580.0, 0.01142) } } },

        };
    }
}
    