using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium239";
        public override double halfLife { get; } = 203558.4d;
        public override double atomicWeight { get; } = 239.05294d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium239() }, { 1.0d, new BetaParticle(-1, 361400.00001) }, { 0.0013d, new GammaParticle(44660.0, 0.02776) }, { 0.0012d, new GammaParticle(49410.0, 0.02509) }, { 0.00035999999999999997d, new GammaParticle(57280.0, 0.02165) }, { 0.0009d, new GammaParticle(57300.0, 0.02164) }, { 0.013000000000000001d, new GammaParticle(61460.0, 0.02017) }, { 0.001d, new GammaParticle(67860.0, 0.01827) }, { 6e-05d, new GammaParticle(88060.0, 0.01408) }, { 8e-05d, new GammaParticle(101965.0, 0.01216) }, { 0.2534d, new GammaParticle(106123.0, 0.01168) }, { 0.00049d, new GammaParticle(106470.0, 0.01164) }, { 0.0001d, new GammaParticle(124400.0, 0.00997) }, { 0.00016d, new GammaParticle(166390.0, 0.00745) }, { 0.00082d, new GammaParticle(181700.0, 0.00682) }, { 0.03363d, new GammaParticle(209753.0, 0.00591) }, { 0.0025900000000000003d, new GammaParticle(226380.0, 0.00548) }, { 0.0051d, new GammaParticle(227830.0, 0.00544) }, { 0.1073d, new GammaParticle(228183.0, 0.00543) }, { 0.001092d, new GammaParticle(254400.0, 0.00487) }, { 0.000766d, new GammaParticle(272840.0, 0.00454) }, { 0.14505d, new GammaParticle(277599.0, 0.00447) }, { 0.007939d, new GammaParticle(285460.0, 0.00434) }, { 0.016d, new GammaParticle(315880.0, 0.00393) }, { 5.2e-05d, new GammaParticle(322260.0, 0.00385) }, { 0.020560000000000002d, new GammaParticle(334310.0, 0.00371) }, { 1.6e-05d, new GammaParticle(392400.0, 0.00316) }, { 3.9e-05d, new GammaParticle(429500.0, 0.00289) }, { 0.00013d, new GammaParticle(434700.0, 0.00285) }, { 2.5999999999999997e-06d, new GammaParticle(447600.0, 0.00277) }, { 8.2e-06d, new GammaParticle(454200.0, 0.00273) }, { 1.6e-05d, new GammaParticle(461900.0, 0.00268) }, { 1.1000000000000001e-05d, new GammaParticle(469800.0, 0.00264) }, { 1e-05d, new GammaParticle(484300.0, 0.00256) }, { 6e-05d, new GammaParticle(492300.0, 0.00252) }, { 3.2e-05d, new GammaParticle(497800.0, 0.00249) }, { 1e-05d, new GammaParticle(498700.0, 0.00249) }, { 7.8e-06d, new GammaParticle(504200.0, 0.00246) }, { 0.4458000618030998d, new GammaParticle(17604.0, 0.07043) }, { 0.13114985746685848d, new GammaParticle(99533.0, 0.01246) }, { 0.20761414827743938d, new GammaParticle(103741.0, 0.01195) }, { 0.07620303915406253d, new GammaParticle(117130.0, 0.01059) }, { 0.10264549374052223d, new GammaParticle(118619.0, 0.01045) }, { 0.026442454586459697d, new GammaParticle(120544.0, 0.01029) } } },

        };
    }
}
    