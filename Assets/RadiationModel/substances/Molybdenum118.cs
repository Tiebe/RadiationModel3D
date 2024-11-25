using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum118 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum118";
        public override double halfLife { get; } = 0.019d;
        public override double atomicWeight { get; } = 117.96525d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium118() }, { 1.0d, new BetaParticle(-1, 5460000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    