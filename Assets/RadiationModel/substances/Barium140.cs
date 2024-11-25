using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium140";
        public override double halfLife { get; } = 1101686.4d;
        public override double atomicWeight { get; } = 139.91061d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum140() }, { 1.0d, new BetaParticle(-1, 522050.0) }, { 0.012195000000000001d, new GammaParticle(13846.0, 0.08955) }, { 0.1409742d, new GammaParticle(29966.0, 0.04137) }, { 1.9512e-05d, new GammaParticle(43800.0, 0.02831) }, { 2.9268e-07d, new GammaParticle(63170.0, 0.01963) }, { 1.9512e-07d, new GammaParticle(99490.0, 0.01246) }, { 0.000160974d, new GammaParticle(113510.0, 0.01092) }, { 0.00060975d, new GammaParticle(118837.0, 0.01043) }, { 0.00202437d, new GammaParticle(132687.0, 0.00934) }, { 0.0621945d, new GammaParticle(162660.0, 0.00762) }, { 9.756e-06d, new GammaParticle(183830.0, 0.00674) }, { 3.6584999999999998e-06d, new GammaParticle(275180.0, 0.00451) }, { 0.042926399999999997d, new GammaParticle(304849.0, 0.00407) }, { 3.6584999999999996e-05d, new GammaParticle(418440.0, 0.00296) }, { 0.030975299999999997d, new GammaParticle(423722.0, 0.00293) }, { 0.01929249d, new GammaParticle(437575.0, 0.00283) }, { 4.878e-06d, new GammaParticle(467500.0, 0.00265) }, { 0.2439d, new GammaParticle(537261.0, 0.00231) }, { 3.12192e-05d, new GammaParticle(551080.0, 0.00225) }, { 8.2926e-06d, new GammaParticle(699890.0, 0.00177) }, { 0.134d, new GammaParticle(5185.0, 0.23912) }, { 0.0054800000000000005d, new GammaParticle(33034.0, 0.03753) }, { 0.01006d, new GammaParticle(33442.0, 0.03707) }, { 0.003d, new GammaParticle(37908.0, 0.03271) }, { 0.00375d, new GammaParticle(38273.0, 0.03239) }, { 0.0007580000000000001d, new GammaParticle(38725.0, 0.03202) } } },

        };
    }
}
    