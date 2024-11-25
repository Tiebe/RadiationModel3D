using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon37 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon37";
        public override double halfLife { get; } = 3024950.4d;
        public override double atomicWeight { get; } = 36.96678d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine37() }, { 0.001966490414d, new GammaParticle(223.0, 5.55983) }, { 0.027594014165409235d, new GammaParticle(2621.0, 0.47304) }, { 0.05457676852335687d, new GammaParticle(2623.0, 0.47268) }, { 0.0070666873112338845d, new GammaParticle(2816.0, 0.44028) }, { 0.0070666873112338845d, new GammaParticle(2816.0, 0.44028) } } },

        };
    }
}
    