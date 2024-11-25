using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium114";
        public override double halfLife { get; } = 0.017d;
        public override double atomicWeight { get; } = 113.96247d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum114() }, { 1.0d, new BetaParticle(-1, 7360000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    