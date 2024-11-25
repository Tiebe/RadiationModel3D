using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony126n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony126n";
        public override double halfLife { get; } = 11.0d;
        public override double atomicWeight { get; } = 125.9073d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony126() } } },

        };
    }
}
    