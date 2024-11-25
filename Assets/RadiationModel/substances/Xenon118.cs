using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon118 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon118";
        public override double halfLife { get; } = 228.0d;
        public override double atomicWeight { get; } = 117.91618d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium118() }, { 1.0d, new BetaParticle(1, 4806000.0) } } },

        };
    }
}
    