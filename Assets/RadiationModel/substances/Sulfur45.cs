using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur45 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur45";
        public override double halfLife { get; } = 0.068d;
        public override double atomicWeight { get; } = 44.99641d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine45() }, { 1.0d, new BetaParticle(-1, 7460000.0) } } },
            { 0.54d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine45() }, { 1.0d, new BetaParticle(-1, 7460000.0) } } },

        };
    }
}
    