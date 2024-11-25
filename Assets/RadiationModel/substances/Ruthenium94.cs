using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium94";
        public override double halfLife { get; } = 3108.0d;
        public override double atomicWeight { get; } = 93.91134d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum94() }, { 1.0d, new BetaParticle(1, 2915040.0) }, { 0.752d, new GammaParticle(367200.0, 0.00338) }, { 0.018047999999999998d, new GammaParticle(525000.0, 0.00236) }, { 0.24816d, new GammaParticle(891200.0, 0.00139) }, { 8e-05d, new GammaParticle(511000.0, 0.00243) }, { 0.040949344965999994d, new GammaParticle(2586.0, 0.47944) }, { 0.19425574856224587d, new GammaParticle(18250.0, 0.06794) }, { 0.3693777306755008d, new GammaParticle(18367.0, 0.0675) }, { 0.09817346525237779d, new GammaParticle(20695.0, 0.05991) }, { 0.11368487276225349d, new GammaParticle(20820.0, 0.05955) }, { 0.015511407509875692d, new GammaParticle(21003.0, 0.05903) } } },

        };
    }
}
    