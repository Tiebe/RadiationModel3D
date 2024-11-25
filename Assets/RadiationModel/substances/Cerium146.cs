using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium146";
        public override double halfLife { get; } = 809.4d;
        public override double atomicWeight { get; } = 145.91881d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium146() }, { 1.0d, new BetaParticle(-1, 522000.0) }, { 0.0017143d, new GammaParticle(12230.0, 0.10138) }, { 0.007742d, new GammaParticle(22880.0, 0.05419) }, { 0.01106d, new GammaParticle(35050.0, 0.03537) }, { 0.0102305d, new GammaParticle(52190.0, 0.02376) }, { 0.0068572d, new GammaParticle(87190.0, 0.01422) }, { 0.038157d, new GammaParticle(98550.0, 0.01258) }, { 0.0269864d, new GammaParticle(100880.0, 0.01229) }, { 0.0061383d, new GammaParticle(106170.0, 0.01168) }, { 0.0013272d, new GammaParticle(132000.0, 0.00939) }, { 0.0823417d, new GammaParticle(133520.0, 0.00929) }, { 0.0340095d, new GammaParticle(141290.0, 0.00878) }, { 0.0025990999999999996d, new GammaParticle(173840.0, 0.00713) }, { 0.055078800000000004d, new GammaParticle(210460.0, 0.00589) }, { 0.0027096999999999998d, new GammaParticle(216000.0, 0.00574) }, { 0.19520900000000002d, new GammaParticle(218230.0, 0.00568) }, { 0.0029862d, new GammaParticle(245500.0, 0.00505) }, { 0.0272076d, new GammaParticle(250890.0, 0.00494) }, { 0.0916874d, new GammaParticle(264560.0, 0.00469) }, { 0.5529999999999999d, new GammaParticle(316740.0, 0.00391) }, { 0.0033733d, new GammaParticle(351490.0, 0.00353) }, { 0.0019908d, new GammaParticle(369230.0, 0.00336) }, { 0.0012166d, new GammaParticle(375650.0, 0.0033) }, { 0.013548500000000002d, new GammaParticle(415710.0, 0.00298) }, { 0.0003318d, new GammaParticle(462700.0, 0.00268) }, { 0.0081844d, new GammaParticle(468020.0, 0.00265) }, { 0.0014378d, new GammaParticle(490800.0, 0.00253) }, { 0.0107282d, new GammaParticle(503000.0, 0.00246) }, { 0.0007742000000000001d, new GammaParticle(526830.0, 0.00235) }, { 0.122d, new GammaParticle(5637.0, 0.21995) }, { 0.059000000000000004d, new GammaParticle(35551.0, 0.03488) }, { 0.10800000000000001d, new GammaParticle(36027.0, 0.03441) }, { 0.033d, new GammaParticle(40857.0, 0.03035) }, { 0.040999999999999995d, new GammaParticle(41266.0, 0.03005) }, { 0.0084d, new GammaParticle(41766.0, 0.02969) } } },

        };
    }
}
    