using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium156";
        public override double halfLife { get; } = 33840.0d;
        public override double atomicWeight { get; } = 155.92554d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium156() }, { 1.0d, new BetaParticle(-1, 361000.0) }, { 0.02626d, new GammaParticle(22600.0, 0.05486) }, { 0.0027d, new GammaParticle(25300.0, 0.04901) }, { 0.030299999999999997d, new GammaParticle(38100.0, 0.03254) }, { 0.02323d, new GammaParticle(65000.0, 0.01907) }, { 0.24239999999999998d, new GammaParticle(87600.0, 0.01415) }, { 0.01818d, new GammaParticle(103000.0, 0.01204) }, { 0.1313d, new GammaParticle(165800.0, 0.00748) }, { 0.2121d, new GammaParticle(204000.0, 0.00608) }, { 0.00505d, new GammaParticle(219000.0, 0.00566) }, { 0.02121d, new GammaParticle(244000.0, 0.00508) }, { 0.024239999999999998d, new GammaParticle(268500.0, 0.00462) }, { 0.02828d, new GammaParticle(291000.0, 0.00426) }, { 0.114d, new GammaParticle(6603.0, 0.18777) }, { 0.03320666817199487d, new GammaParticle(40901.0, 0.03031) }, { 0.0599182031252163d, new GammaParticle(41541.0, 0.02985) }, { 0.018876663100786048d, new GammaParticle(47146.0, 0.0263) }, { 0.023746842180788846d, new GammaParticle(47645.0, 0.02602) }, { 0.0048701790800028d, new GammaParticle(48248.0, 0.0257) } } },

        };
    }
}
    