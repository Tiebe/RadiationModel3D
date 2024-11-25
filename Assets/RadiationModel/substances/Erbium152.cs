using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium152";
        public override double halfLife { get; } = 10.3d;
        public override double atomicWeight { get; } = 151.93505d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium148() }, { 1.0d, new AlphaParticle(5956002.09) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium152() }, { 1.0d, new BetaParticle(1, 4809000.0) }, { 0.09d, new GammaParticle(179300.0, 0.00691) }, { 0.04d, new GammaParticle(511000.0, 0.00243) }, { 0.014648731276d, new GammaParticle(7656.0, 0.16194) }, { 0.019198764746044115d, new GammaParticle(46700.0, 0.02655) }, { 0.034191922967131104d, new GammaParticle(47547.0, 0.02608) }, { 0.011046787529226016d, new GammaParticle(53982.0, 0.02297) }, { 0.01391895228682478d, new GammaParticle(54577.0, 0.02272) }, { 0.002872164757598764d, new GammaParticle(55293.0, 0.02242) } } },

        };
    }
}
    