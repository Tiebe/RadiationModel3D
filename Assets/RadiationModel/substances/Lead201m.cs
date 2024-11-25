using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead201m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead201m";
        public override double halfLife { get; } = 60.8d;
        public override double atomicWeight { get; } = 200.97355d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead201() } } },

        };
    }
}
    