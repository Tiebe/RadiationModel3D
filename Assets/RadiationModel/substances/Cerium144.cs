using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium144";
        public override double halfLife { get; } = 24616224.0d;
        public override double atomicWeight { get; } = 143.91365d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium144() }, { 1.0d, new BetaParticle(-1, 159349.99999) }, { 0.0019962d, new GammaParticle(33568.0, 0.03694) }, { 0.00257288d, new GammaParticle(40980.0, 0.03025) }, { 0.0009981d, new GammaParticle(53395.0, 0.02322) }, { 9.7592e-06d, new GammaParticle(59030.0, 0.021) }, { 0.013640699999999999d, new GammaParticle(80120.0, 0.01547) }, { 0.00039924000000000003d, new GammaParticle(99961.0, 0.0124) }, { 0.1109d, new GammaParticle(133515.0, 0.00929) }, { 0.015148063477718162d, new GammaParticle(5637.0, 0.21995) }, { 0.024646642472104144d, new GammaParticle(35551.0, 0.03488) }, { 0.045008477852637216d, new GammaParticle(36027.0, 0.03441) }, { 0.013692555102053059d, new GammaParticle(40857.0, 0.03035) }, { 0.017197849208178642d, new GammaParticle(41266.0, 0.03005) }, { 0.003505294106125583d, new GammaParticle(41766.0, 0.02969) } } },

        };
    }
}
    