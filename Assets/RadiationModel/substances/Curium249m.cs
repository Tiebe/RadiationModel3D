using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium249m : RadioactiveSubstance
    {
        public override string name { get; } = "Curium249m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 249.07601d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    