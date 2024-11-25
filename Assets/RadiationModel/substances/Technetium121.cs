using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium121";
        public override double halfLife { get; } = 0.022d;
        public override double atomicWeight { get; } = 120.96614d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium121() }, { 1.0d, new BetaParticle(-1, 6540000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    