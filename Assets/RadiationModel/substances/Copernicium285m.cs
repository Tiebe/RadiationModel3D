using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium285m : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium285m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 285.1778d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    