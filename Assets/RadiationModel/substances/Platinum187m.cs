using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum187m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum187m";
        public override double halfLife { get; } = 0.00031d;
        public override double atomicWeight { get; } = 186.9608d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    