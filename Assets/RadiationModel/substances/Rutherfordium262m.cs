using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium262m : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium262m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 262.11099d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    