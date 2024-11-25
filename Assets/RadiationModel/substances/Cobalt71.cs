using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt71 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt71";
        public override double halfLife { get; } = 0.08d;
        public override double atomicWeight { get; } = 70.95237d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel71() }, { 1.0d, new BetaParticle(-1, 5518100.0) } } },
            { 0.16d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel71() }, { 1.0d, new BetaParticle(-1, 5518100.0) } } },

        };
    }
}
    