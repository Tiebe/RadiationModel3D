using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium116";
        public override double halfLife { get; } = 11.8d;
        public override double atomicWeight { get; } = 115.9143d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver116() }, { 1.0d, new BetaParticle(-1, 1356000.0) }, { 0.0385d, new GammaParticle(23700.0, 0.05231) }, { 0.07777d, new GammaParticle(91000.0, 0.01362) }, { 0.07854d, new GammaParticle(101200.0, 0.01225) }, { 0.77d, new GammaParticle(114700.0, 0.01081) }, { 0.11396d, new GammaParticle(178000.0, 0.00697) }, { 0.01848d, new GammaParticle(216100.0, 0.00574) }, { 0.06083d, new GammaParticle(278300.0, 0.00446) }, { 0.03157d, new GammaParticle(302600.0, 0.0041) }, { 0.011000000000000001d, new GammaParticle(3218.0, 0.38528) }, { 0.031d, new GammaParticle(21990.0, 0.05638) }, { 0.06d, new GammaParticle(22163.0, 0.05594) }, { 0.016d, new GammaParticle(25030.0, 0.04953) }, { 0.019d, new GammaParticle(25211.0, 0.04918) }, { 0.0028000000000000004d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    