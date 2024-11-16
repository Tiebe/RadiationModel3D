using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium24j : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium24j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 24.00161d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    