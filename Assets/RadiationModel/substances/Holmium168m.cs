using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium168m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium168m";
        public override double halfLife { get; } = 132.0d;
        public override double atomicWeight { get; } = 167.93559d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium168() }, { 0.000412d, new GammaParticle(59000.0, 0.02101) }, { 0.15493661803d, new GammaParticle(7656.0, 0.16194) }, { 0.037081880822858855d, new GammaParticle(46700.0, 0.02655) }, { 0.06604074946190357d, new GammaParticle(47547.0, 0.02608) }, { 0.02133656326606156d, new GammaParticle(53982.0, 0.02297) }, { 0.026884069715237567d, new GammaParticle(54577.0, 0.02272) }, { 0.005547506449176005d, new GammaParticle(55293.0, 0.02242) } } },
            { 0.005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium168() }, { 1.0d, new BetaParticle(-1, 1494614.99999) } } },

        };
    }
}
    