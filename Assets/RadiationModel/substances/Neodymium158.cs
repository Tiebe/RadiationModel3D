using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium158";
        public override double halfLife { get; } = 0.82d;
        public override double atomicWeight { get; } = 157.94221d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium158() }, { 1.0d, new BetaParticle(-1, 2635500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    