using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum115 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum115";
        public override double halfLife { get; } = 0.0455d;
        public override double atomicWeight { get; } = 114.95217d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium115() }, { 1.0d, new BetaParticle(-1, 5625000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    