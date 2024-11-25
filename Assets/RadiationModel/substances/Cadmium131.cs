using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium131";
        public override double halfLife { get; } = 0.068d;
        public override double atomicWeight { get; } = 130.94073d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium131() }, { 1.0d, new BetaParticle(-1, 6406200.0) } } },
            { 0.035d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium131() }, { 1.0d, new BetaParticle(-1, 6406200.0) } } },

        };
    }
}
    