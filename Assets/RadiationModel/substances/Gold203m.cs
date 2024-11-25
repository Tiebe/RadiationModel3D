using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold203m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold203m";
        public override double halfLife { get; } = 0.00014d;
        public override double atomicWeight { get; } = 202.97584d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    