using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium123";
        public override double halfLife { get; } = 2.903237189662464e+24d;
        public override double atomicWeight { get; } = 122.90427d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony123() }, { 0.056576893999999996d, new GammaParticle(3941.0, 0.3146) }, { 0.0004453641209721018d, new GammaParticle(26111.0, 0.04748) }, { 0.0008315237508814448d, new GammaParticle(26359.0, 0.04704) }, { 0.00023654691644279456d, new GammaParticle(29821.0, 0.04158) }, { 0.00028551212814645306d, new GammaParticle(30069.0, 0.04123) }, { 4.896521170365847e-05d, new GammaParticle(30387.0, 0.0408) } } },

        };
    }
}
    