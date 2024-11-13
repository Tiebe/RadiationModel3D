
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium41i : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium41i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 40.97079d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    