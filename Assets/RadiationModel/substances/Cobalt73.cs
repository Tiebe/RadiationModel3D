using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt73 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt73";
        public override double halfLife { get; } = 0.0407d;
        public override double atomicWeight { get; } = 72.95924d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel73() }, { 1.0d, new BetaParticle(-1, 6069100.0) } } },
            { 0.22d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel73() }, { 1.0d, new BetaParticle(-1, 6069100.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    