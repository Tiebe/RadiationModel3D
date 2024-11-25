using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth200n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth200n";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 199.97859d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth200() } } },

        };
    }
}
    