using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium101m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium101m";
        public override double halfLife { get; } = 0.00064d;
        public override double atomicWeight { get; } = 100.90753d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium101() } } },

        };
    }
}
    