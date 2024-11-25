using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium160";
        public override double halfLife { get; } = 0.725d;
        public override double atomicWeight { get; } = 159.94322d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium160() }, { 1.0d, new BetaParticle(-1, 3669300.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    