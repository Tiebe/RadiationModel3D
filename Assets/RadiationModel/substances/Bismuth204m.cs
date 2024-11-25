using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth204m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth204m";
        public override double halfLife { get; } = 0.013d;
        public override double atomicWeight { get; } = 203.9787d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth204() } } },

        };
    }
}
    