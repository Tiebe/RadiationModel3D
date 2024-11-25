using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur39 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur39";
        public override double halfLife { get; } = 11.5d;
        public override double atomicWeight { get; } = 38.97514d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine39() }, { 1.0d, new BetaParticle(-1, 3320100.0) }, { 0.37d, new GammaParticle(396500.0, 0.00313) }, { 0.035d, new GammaParticle(396500.0, 0.00313) }, { 0.106d, new GammaParticle(484850.0, 0.00256) }, { 0.128d, new GammaParticle(874310.0, 0.00142) }, { 0.035d, new GammaParticle(903800.0, 0.00137) }, { 0.52d, new GammaParticle(1300520.0, 0.00095) }, { 0.44d, new GammaParticle(1696620.0, 0.00073) } } },

        };
    }
}
    