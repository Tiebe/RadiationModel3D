using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium166";
        public override double halfLife { get; } = 406.2d;
        public override double atomicWeight { get; } = 165.94218d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium166() }, { 1.0d, new BetaParticle(1, 3867500.0) }, { 0.00168d, new GammaParticle(14200.0, 0.08731) }, { 0.00019199999999999998d, new GammaParticle(22850.0, 0.05426) }, { 0.0158d, new GammaParticle(26100.0, 0.0475) }, { 0.436d, new GammaParticle(78760.0, 0.01574) }, { 0.03488d, new GammaParticle(93050.0, 0.01332) }, { 0.004796d, new GammaParticle(170000.0, 0.00729) }, { 0.016568d, new GammaParticle(244600.0, 0.00507) }, { 0.017004d, new GammaParticle(283920.0, 0.00437) }, { 0.013951999999999999d, new GammaParticle(298770.0, 0.00415) }, { 0.018312d, new GammaParticle(306800.0, 0.00404) }, { 0.012643999999999999d, new GammaParticle(338980.0, 0.00366) }, { 0.049704d, new GammaParticle(341820.0, 0.00363) }, { 0.011335999999999999d, new GammaParticle(355100.0, 0.00349) }, { 0.042728d, new GammaParticle(377600.0, 0.00328) }, { 0.04796d, new GammaParticle(407910.0, 0.00304) }, { 0.013951999999999999d, new GammaParticle(430740.0, 0.00288) }, { 0.0436d, new GammaParticle(483050.0, 0.00257) }, { 0.03698d, new GammaParticle(511000.0, 0.00243) }, { 0.44299999999999995d, new GammaParticle(8810.0, 0.14073) }, { 0.28800000000000003d, new GammaParticle(52965.0, 0.02341) }, { 0.51d, new GammaParticle(54070.0, 0.02293) }, { 0.166d, new GammaParticle(61387.0, 0.0202) }, { 0.21d, new GammaParticle(62084.0, 0.01997) }, { 0.044000000000000004d, new GammaParticle(62927.0, 0.0197) } } },

        };
    }
}
    