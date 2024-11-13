
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium32m : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium32m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 32.02463d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    