using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium120";
        public override double halfLife { get; } = 0.021d;
        public override double atomicWeight { get; } = 119.96243d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium120() }, { 1.0d, new BetaParticle(-1, 7360000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    