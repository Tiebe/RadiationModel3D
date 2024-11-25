using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium138";
        public override double halfLife { get; } = 18144.0d;
        public override double atomicWeight { get; } = 137.91195d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium138() }, { 1.0d, new BetaParticle(1, 2774450.0) }, { 0.000288d, new GammaParticle(62600.0, 0.01981) }, { 0.0008640000000000001d, new GammaParticle(116300.0, 0.01066) }, { 0.001104d, new GammaParticle(126140.0, 0.00983) }, { 0.0017519999999999999d, new GammaParticle(132730.0, 0.00934) }, { 0.000144d, new GammaParticle(168000.0, 0.00738) }, { 0.000288d, new GammaParticle(178500.0, 0.00695) }, { 0.0025440000000000003d, new GammaParticle(194210.0, 0.00638) }, { 0.005496d, new GammaParticle(199500.0, 0.00621) }, { 0.0007199999999999999d, new GammaParticle(214130.0, 0.00579) }, { 0.0028799999999999997d, new GammaParticle(215310.0, 0.00576) }, { 0.00021600000000000002d, new GammaParticle(234000.0, 0.0053) }, { 0.00038399999999999996d, new GammaParticle(284300.0, 0.00436) }, { 0.02928d, new GammaParticle(325760.0, 0.00381) }, { 0.00024d, new GammaParticle(326900.0, 0.00379) }, { 0.004128d, new GammaParticle(341650.0, 0.00363) }, { 0.00040800000000000005d, new GammaParticle(541000.0, 0.00229) }, { 0.114d, new GammaParticle(5637.0, 0.21995) }, { 0.22d, new GammaParticle(35551.0, 0.03488) }, { 0.402d, new GammaParticle(36027.0, 0.03441) }, { 0.1223d, new GammaParticle(40857.0, 0.03035) }, { 0.1536d, new GammaParticle(41266.0, 0.03005) }, { 0.0313d, new GammaParticle(41766.0, 0.02969) } } },

        };
    }
}
    