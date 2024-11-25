using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon33 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon33";
        public override double halfLife { get; } = 0.173d;
        public override double atomicWeight { get; } = 32.98993d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur33() }, { 1.0d, new BetaParticle(1, 8600779.15) }, { 0.419d, new GammaParticle(810600.0, 0.00153) }, { 0.01d, new GammaParticle(1541500.0, 0.0008) }, { 0.006999999999999999d, new GammaParticle(2352400.0, 0.00053) }, { 1.96920442d, new GammaParticle(511000.0, 0.00243) }, { 6.32060524981044e-07d, new GammaParticle(223.0, 5.55983) }, { 8.871546681473924e-06d, new GammaParticle(2621.0, 0.47304) }, { 1.754657175924431e-05d, new GammaParticle(2623.0, 0.47268) }, { 2.271958185901768e-06d, new GammaParticle(2816.0, 0.44028) }, { 2.271958185901768e-06d, new GammaParticle(2816.0, 0.44028) } } },
            { 0.387d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur32() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    