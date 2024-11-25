using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium262m : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium262m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 262.12289d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    