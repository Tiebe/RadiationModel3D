using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc84 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc84";
        public override double halfLife { get; } = 0.0536d;
        public override double atomicWeight { get; } = 83.96583d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium84() }, { 1.0d, new BetaParticle(-1, 6132000.0) } } },
            { 0.73d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium84() }, { 1.0d, new BetaParticle(-1, 6132000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    