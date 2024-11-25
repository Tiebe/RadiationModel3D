using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium94m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium94m";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 93.91418d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium94() } } },

        };
    }
}
    