using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium90q : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium90q";
        public override double halfLife { get; } = 0.00619d;
        public override double atomicWeight { get; } = 89.91167d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium90() } } },

        };
    }
}
    