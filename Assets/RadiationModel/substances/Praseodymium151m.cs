using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium151m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium151m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 150.92835d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    