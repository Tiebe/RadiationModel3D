using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium192n : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium192n";
        public override double halfLife { get; } = 61.0d;
        public override double atomicWeight { get; } = 191.96638d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium192() } } },

        };
    }
}
    