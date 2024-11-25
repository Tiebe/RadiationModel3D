using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium86";
        public override double halfLife { get; } = 0.043d;
        public override double atomicWeight { get; } = 85.96376d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium86() }, { 1.0d, new BetaParticle(-1, 7820000.0) }, { 0.07d, new GammaParticle(527000.0, 0.00235) } } },
            { 0.6d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium86() }, { 1.0d, new BetaParticle(-1, 7820000.0) }, { 0.07d, new GammaParticle(527000.0, 0.00235) } } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium84() }, { 1.0d, new BetaParticle(-1, 943688103.47199) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    