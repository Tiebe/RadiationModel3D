
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium22i : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium22i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 22.01465d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    