using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold201m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold201m";
        public override double halfLife { get; } = 0.00034d;
        public override double atomicWeight { get; } = 200.9723d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    