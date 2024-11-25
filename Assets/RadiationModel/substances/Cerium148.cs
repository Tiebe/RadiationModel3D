using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium148";
        public override double halfLife { get; } = 56.8d;
        public override double atomicWeight { get; } = 147.92442d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium148() }, { 1.0d, new BetaParticle(-1, 1068500.0) }, { 0.001368d, new GammaParticle(74500.0, 0.01664) }, { 0.021033d, new GammaParticle(90890.0, 0.01364) }, { 0.013167d, new GammaParticle(98000.0, 0.01265) }, { 0.015903d, new GammaParticle(98166.0, 0.01263) }, { 0.126882d, new GammaParticle(98990.0, 0.01252) }, { 0.036765d, new GammaParticle(101029.0, 0.01227) }, { 0.002565d, new GammaParticle(103200.0, 0.01201) }, { 0.053694d, new GammaParticle(105200.0, 0.01179) }, { 0.038475d, new GammaParticle(116920.0, 0.0106) }, { 0.13509000000000002d, new GammaParticle(121169.0, 0.01023) }, { 0.011286000000000001d, new GammaParticle(167800.0, 0.00739) }, { 0.0034200000000000003d, new GammaParticle(168520.0, 0.00736) }, { 0.016929d, new GammaParticle(184530.0, 0.00672) }, { 0.01539d, new GammaParticle(187900.0, 0.0066) }, { 0.011798999999999999d, new GammaParticle(188500.0, 0.00658) }, { 0.016929d, new GammaParticle(191600.0, 0.00647) }, { 0.0034200000000000003d, new GammaParticle(193800.0, 0.0064) }, { 0.04104d, new GammaParticle(194690.0, 0.00637) }, { 0.06669d, new GammaParticle(195977.0, 0.00633) }, { 0.0034200000000000003d, new GammaParticle(231600.0, 0.00535) }, { 0.01026d, new GammaParticle(233710.0, 0.00531) }, { 0.009576d, new GammaParticle(247520.0, 0.00501) }, { 0.174078d, new GammaParticle(269520.0, 0.0046) }, { 0.006840000000000001d, new GammaParticle(271500.0, 0.00457) }, { 0.055746000000000004d, new GammaParticle(273770.0, 0.00453) }, { 0.008208d, new GammaParticle(285500.0, 0.00434) }, { 0.01881d, new GammaParticle(287170.0, 0.00432) }, { 0.05814d, new GammaParticle(289640.0, 0.00428) }, { 0.171d, new GammaParticle(291724.0, 0.00425) }, { 0.077463d, new GammaParticle(324850.0, 0.00382) }, { 0.01539d, new GammaParticle(332700.0, 0.00373) }, { 0.005985000000000001d, new GammaParticle(346300.0, 0.00358) }, { 0.018126d, new GammaParticle(352400.0, 0.00352) }, { 0.016587d, new GammaParticle(369090.0, 0.00336) }, { 0.007011d, new GammaParticle(375000.0, 0.00331) }, { 0.013509d, new GammaParticle(390790.0, 0.00317) }, { 0.007866d, new GammaParticle(399430.0, 0.0031) }, { 0.037278d, new GammaParticle(421780.0, 0.00294) }, { 0.013680000000000001d, new GammaParticle(478170.0, 0.00259) }, { 0.007011d, new GammaParticle(521200.0, 0.00238) }, { 0.06911740277476451d, new GammaParticle(5637.0, 0.21995) }, { 0.11978276964544608d, new GammaParticle(35551.0, 0.03488) }, { 0.2187413616607854d, new GammaParticle(36027.0, 0.03441) }, { 0.0665458662575705d, new GammaParticle(40857.0, 0.03035) }, { 0.08358160801950856d, new GammaParticle(41266.0, 0.03005) }, { 0.01703574176193805d, new GammaParticle(41766.0, 0.02969) } } },

        };
    }
}
    