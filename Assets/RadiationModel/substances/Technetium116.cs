using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium116";
        public override double halfLife { get; } = 0.057d;
        public override double atomicWeight { get; } = 115.94502d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium116() }, { 1.0d, new BetaParticle(-1, 6429500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    