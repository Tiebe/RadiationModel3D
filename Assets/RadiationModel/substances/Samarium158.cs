using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium158";
        public override double halfLife { get; } = 318.0d;
        public override double atomicWeight { get; } = 157.92995d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium158() }, { 1.0d, new BetaParticle(-1, 1009250.0) }, { 0.055625999999999995d, new GammaParticle(100200.0, 0.01237) }, { 0.01397d, new GammaParticle(108700.0, 0.01141) }, { 0.008763d, new GammaParticle(132300.0, 0.00937) }, { 0.05842d, new GammaParticle(149000.0, 0.00832) }, { 0.047498d, new GammaParticle(177700.0, 0.00698) }, { 0.18161000000000002d, new GammaParticle(189400.0, 0.00655) }, { 0.049530000000000005d, new GammaParticle(190700.0, 0.0065) }, { 0.1016d, new GammaParticle(224100.0, 0.00553) }, { 0.06223d, new GammaParticle(226600.0, 0.00547) }, { 0.08001d, new GammaParticle(229700.0, 0.0054) }, { 0.008381999999999999d, new GammaParticle(283000.0, 0.00438) }, { 0.020193d, new GammaParticle(285400.0, 0.00434) }, { 0.025146d, new GammaParticle(299700.0, 0.00414) }, { 0.09906000000000001d, new GammaParticle(321300.0, 0.00386) }, { 0.127d, new GammaParticle(324500.0, 0.00382) }, { 0.024638d, new GammaParticle(326800.0, 0.00379) }, { 0.04445d, new GammaParticle(338600.0, 0.00366) }, { 0.07873999999999999d, new GammaParticle(361700.0, 0.00343) }, { 0.14859d, new GammaParticle(363600.0, 0.00341) }, { 0.00635d, new GammaParticle(376500.0, 0.00329) }, { 0.036195d, new GammaParticle(551200.0, 0.00225) }, { 0.019684999999999998d, new GammaParticle(791400.0, 0.00157) }, { 0.014478d, new GammaParticle(1162900.0, 0.00107) }, { 0.010541d, new GammaParticle(1209900.0, 0.00102) }, { 0.009906d, new GammaParticle(1343300.0, 0.00092) }, { 0.004318d, new GammaParticle(1448500.0, 0.00086) } } },

        };
    }
}
    