using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead210 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead210";
        public override double halfLife { get; } = 700563756.63594d;
        public override double atomicWeight { get; } = 209.98419d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth210() }, { 1.0d, new BetaParticle(-1, 31750.0) }, { 0.0425d, new GammaParticle(46539.0, 0.02664) }, { 0.2266627d, new GammaParticle(12904.0, 0.09608) } } },
            { 1.9e-08d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury206() }, { 1.0d, new AlphaParticle(4814602.09) } } },

        };
    }
}
    