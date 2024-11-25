using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium270m : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium270m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 270.14608d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    