using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium248 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium248";
        public override double halfLife { get; } = 34.5d;
        public override double atomicWeight { get; } = 248.07719d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.95d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium244() }, { 1.0d, new AlphaParticle(9016902.09) } } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium248() } } },
            { 0.001d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    