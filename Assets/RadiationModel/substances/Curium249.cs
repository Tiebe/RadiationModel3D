using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium249";
        public override double halfLife { get; } = 3849.0d;
        public override double atomicWeight { get; } = 249.07595d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Berkelium249() }, { 1.0d, new BetaParticle(-1, 452199.99999) }, { 3.26e-07d, new GammaParticle(8770.0, 0.14137) }, { 3.4e-07d, new GammaParticle(43700.0, 0.02837) }, { 5.4000000000000005e-05d, new GammaParticle(85200.0, 0.01455) }, { 0.00039d, new GammaParticle(136900.0, 0.00906) }, { 2.8999999999999997e-05d, new GammaParticle(158600.0, 0.00782) }, { 2.2000000000000003e-05d, new GammaParticle(168800.0, 0.00735) }, { 0.0002d, new GammaParticle(180500.0, 0.00687) }, { 0.0001d, new GammaParticle(191600.0, 0.00647) }, { 0.0034999999999999996d, new GammaParticle(368760.0, 0.00336) }, { 6.3e-05d, new GammaParticle(389000.0, 0.00319) }, { 9.2e-05d, new GammaParticle(421300.0, 0.00294) }, { 7.2e-05d, new GammaParticle(475400.0, 0.00261) }, { 0.0008799999999999999d, new GammaParticle(518500.0, 0.00239) }, { 7.000000000000001e-05d, new GammaParticle(529500.0, 0.00234) }, { 0.0003d, new GammaParticle(549400.0, 0.00226) }, { 0.0084d, new GammaParticle(560400.0, 0.00221) }, { 6.4e-05d, new GammaParticle(603400.0, 0.00205) }, { 0.0018d, new GammaParticle(621900.0, 0.00199) }, { 0.015d, new GammaParticle(634300.0, 0.00195) }, { 0.0014000000000000002d, new GammaParticle(652800.0, 0.0019) }, { 0.00103943275719192d, new GammaParticle(19075.0, 0.065) }, { 0.0004720082107268595d, new GammaParticle(107218.0, 0.01156) }, { 0.0007347574886781748d, new GammaParticle(112150.0, 0.01106) }, { 0.0002771817817688077d, new GammaParticle(126449.0, 0.00981) }, { 0.0003753041325149657d, new GammaParticle(128067.0, 0.00968) }, { 9.812235074615794e-05d, new GammaParticle(130195.0, 0.00952) } } },

        };
    }
}
    