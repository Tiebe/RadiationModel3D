using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper81 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper81";
        public override double halfLife { get; } = 0.0732d;
        public override double atomicWeight { get; } = 80.96574d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc81() }, { 1.0d, new BetaParticle(-1, 7145000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    