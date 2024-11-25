using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium230";
        public override double halfLife { get; } = 5580.0d;
        public override double atomicWeight { get; } = 230.03705d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium230() }, { 1.0d, new BetaParticle(-1, 339000.0) }, { 0.0022d, new GammaParticle(49200.0, 0.0252) }, { 0.034d, new GammaParticle(63000.0, 0.01968) }, { 0.096d, new GammaParticle(72000.0, 0.01722) }, { 0.018000000000000002d, new GammaParticle(92100.0, 0.01346) }, { 0.013999999999999999d, new GammaParticle(101000.0, 0.01228) }, { 0.0026d, new GammaParticle(110700.0, 0.0112) }, { 0.00026d, new GammaParticle(117800.0, 0.01052) }, { 0.00026d, new GammaParticle(125300.0, 0.00989) }, { 0.00026d, new GammaParticle(132700.0, 0.00934) }, { 0.0038d, new GammaParticle(134300.0, 0.00923) }, { 0.0005099999999999999d, new GammaParticle(138700.0, 0.00894) }, { 0.0006d, new GammaParticle(141400.0, 0.00877) }, { 0.0048d, new GammaParticle(147900.0, 0.00838) }, { 0.0017000000000000001d, new GammaParticle(151500.0, 0.00818) }, { 0.0005099999999999999d, new GammaParticle(177500.0, 0.00699) }, { 0.0098d, new GammaParticle(184100.0, 0.00673) }, { 0.014199999999999999d, new GammaParticle(189200.0, 0.00655) }, { 0.0012d, new GammaParticle(192600.0, 0.00644) }, { 0.00111d, new GammaParticle(197100.0, 0.00629) }, { 0.0029d, new GammaParticle(198200.0, 0.00626) }, { 0.026000000000000002d, new GammaParticle(202800.0, 0.00611) }, { 0.0096d, new GammaParticle(211800.0, 0.00585) }, { 0.00026d, new GammaParticle(236300.0, 0.00525) }, { 0.00026d, new GammaParticle(247400.0, 0.00501) }, { 0.0084d, new GammaParticle(251500.0, 0.00493) }, { 0.0014000000000000002d, new GammaParticle(255700.0, 0.00485) }, { 0.0029d, new GammaParticle(259900.0, 0.00477) }, { 0.0008500000000000001d, new GammaParticle(274600.0, 0.00452) }, { 0.015d, new GammaParticle(285200.0, 0.00435) }, { 0.0008500000000000001d, new GammaParticle(288200.0, 0.0043) }, { 0.0037d, new GammaParticle(292900.0, 0.00423) }, { 0.0010199999999999999d, new GammaParticle(296100.0, 0.00419) }, { 0.00043d, new GammaParticle(297600.0, 0.00417) }, { 0.0008500000000000001d, new GammaParticle(316400.0, 0.00392) }, { 0.0005099999999999999d, new GammaParticle(363900.0, 0.00341) }, { 0.00026d, new GammaParticle(375800.0, 0.0033) }, { 0.0007599999999999999d, new GammaParticle(412900.0, 0.003) }, { 0.00026d, new GammaParticle(437700.0, 0.00283) }, { 0.00026d, new GammaParticle(440000.0, 0.00282) }, { 0.0127d, new GammaParticle(448900.0, 0.00276) }, { 0.016d, new GammaParticle(457900.0, 0.00271) }, { 0.025d, new GammaParticle(469700.0, 0.00264) }, { 0.00026d, new GammaParticle(473500.0, 0.00262) }, { 0.021d, new GammaParticle(478700.0, 0.00259) }, { 0.0016d, new GammaParticle(484200.0, 0.00256) }, { 0.0037d, new GammaParticle(490500.0, 0.00253) }, { 0.0055000000000000005d, new GammaParticle(509400.0, 0.00243) }, { 0.0010199999999999999d, new GammaParticle(536900.0, 0.00231) }, { 0.1298104916280064d, new GammaParticle(15349.0, 0.08078) }, { 0.044641832206611325d, new GammaParticle(87674.0, 0.01414) }, { 0.07256474675977133d, new GammaParticle(90886.0, 0.01364) }, { 0.025586732542548653d, new GammaParticle(102818.0, 0.01206) }, { 0.034107114479217354d, new GammaParticle(104107.0, 0.01191) }, { 0.008520381936668701d, new GammaParticle(105738.0, 0.01173) } } },

        };
    }
}
    