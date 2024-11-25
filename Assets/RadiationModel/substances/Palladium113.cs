using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium113";
        public override double halfLife { get; } = 93.0d;
        public override double atomicWeight { get; } = 112.91026d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver113() }, { 1.0d, new BetaParticle(-1, 1718500.0) }, { 0.0015d, new GammaParticle(43600.0, 0.02844) }, { 0.0004d, new GammaParticle(49600.0, 0.025) }, { 0.0001d, new GammaParticle(51500.0, 0.02407) }, { 0.065d, new GammaParticle(95740.0, 0.01295) }, { 0.005d, new GammaParticle(96000.0, 0.01292) }, { 0.0034999999999999996d, new GammaParticle(147730.0, 0.00839) }, { 0.0002d, new GammaParticle(178500.0, 0.00695) }, { 0.0008d, new GammaParticle(205870.0, 0.00602) }, { 0.024d, new GammaParticle(222060.0, 0.00558) }, { 0.0027d, new GammaParticle(230490.0, 0.00538) }, { 0.0043d, new GammaParticle(254610.0, 0.00487) }, { 0.0027d, new GammaParticle(257100.0, 0.00482) }, { 0.011000000000000001d, new GammaParticle(270810.0, 0.00458) }, { 0.0004d, new GammaParticle(273600.0, 0.00453) }, { 0.0021d, new GammaParticle(326280.0, 0.0038) }, { 0.0011d, new GammaParticle(336300.0, 0.00369) }, { 0.0004d, new GammaParticle(337320.0, 0.00368) }, { 0.0066d, new GammaParticle(366800.0, 0.00338) }, { 0.0028000000000000004d, new GammaParticle(386900.0, 0.0032) }, { 0.0014000000000000002d, new GammaParticle(414900.0, 0.00299) }, { 0.0011d, new GammaParticle(433400.0, 0.00286) }, { 0.0011d, new GammaParticle(472100.0, 0.00263) }, { 0.017d, new GammaParticle(482600.0, 0.00257) }, { 0.0021d, new GammaParticle(510900.0, 0.00243) }, { 0.0018d, new GammaParticle(534200.0, 0.00232) }, { 0.016d, new GammaParticle(567700.0, 0.00218) }, { 0.0023d, new GammaParticle(607000.0, 0.00204) }, { 0.06d, new GammaParticle(643700.0, 0.00193) }, { 0.0007000000000000001d, new GammaParticle(673200.0, 0.00184) }, { 0.048d, new GammaParticle(739630.0, 0.00168) }, { 0.0007000000000000001d, new GammaParticle(781900.0, 0.00159) }, { 0.07d, new GammaParticle(3218.0, 0.38528) }, { 0.04d, new GammaParticle(21990.0, 0.05638) }, { 0.07d, new GammaParticle(22163.0, 0.05594) }, { 0.021d, new GammaParticle(25030.0, 0.04953) }, { 0.024d, new GammaParticle(25211.0, 0.04918) }, { 0.0036d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    