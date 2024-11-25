using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum183 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum183";
        public override double halfLife { get; } = 440640.0d;
        public override double atomicWeight { get; } = 182.95138d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten183() }, { 1.0d, new BetaParticle(-1, 536099.99999) }, { 0.0046784d, new GammaParticle(40976.0, 0.03026) }, { 0.052224000000000007d, new GammaParticle(46483.8, 0.02667) }, { 0.052767999999999995d, new GammaParticle(52595.2, 0.02357) }, { 0.0043792d, new GammaParticle(82918.0, 0.01495) }, { 0.0135456d, new GammaParticle(84711.0, 0.01464) }, { 0.067728d, new GammaParticle(99079.3, 0.01251) }, { 0.0032912d, new GammaParticle(101934.0, 0.01216) }, { 0.0015504000000000002d, new GammaParticle(102481.0, 0.0121) }, { 0.0015504000000000002d, new GammaParticle(103147.0, 0.01202) }, { 0.11152d, new GammaParticle(107931.0, 0.01149) }, { 0.0060656d, new GammaParticle(109726.0, 0.0113) }, { 0.0006664d, new GammaParticle(120373.0, 0.0103) }, { 0.0034816d, new GammaParticle(142270.0, 0.00871) }, { 0.025568d, new GammaParticle(144121.7, 0.0086) }, { 0.029647999999999997d, new GammaParticle(160526.0, 0.00772) }, { 0.090848d, new GammaParticle(161343.9, 0.00768) }, { 0.049776d, new GammaParticle(162321.1, 0.00764) }, { 0.0036176000000000003d, new GammaParticle(192643.0, 0.00644) }, { 0.003944d, new GammaParticle(203284.0, 0.0061) }, { 0.009084799999999999d, new GammaParticle(205085.0, 0.00605) }, { 0.006201600000000001d, new GammaParticle(208810.0, 0.00594) }, { 0.046239999999999996d, new GammaParticle(209867.0, 0.00591) }, { 0.087584d, new GammaParticle(244263.0, 0.00508) }, { 0.0037264000000000004d, new GammaParticle(245235.0, 0.00506) }, { 0.272d, new GammaParticle(246059.0, 0.00504) }, { 0.0001088d, new GammaParticle(286400.0, 0.00433) }, { 0.038352d, new GammaParticle(291724.0, 0.00425) }, { 0.02176d, new GammaParticle(313005.0, 0.00396) }, { 0.052224000000000007d, new GammaParticle(313276.0, 0.00396) }, { 0.11587199999999999d, new GammaParticle(353989.0, 0.0035) }, { 0.0049775999999999996d, new GammaParticle(365644.0, 0.00339) }, { 0.005168000000000001d, new GammaParticle(406612.0, 0.00305) }, { 0.484167760956892d, new GammaParticle(9740.0, 0.12729) }, { 0.24597629375483074d, new GammaParticle(57983.0, 0.02138) }, { 0.4272647103610053d, new GammaParticle(59320.0, 0.0209) }, { 0.1416236963132214d, new GammaParticle(67335.0, 0.01841) }, { 0.18042858910304405d, new GammaParticle(68117.0, 0.0182) }, { 0.03880489278982266d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    