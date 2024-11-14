using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium24 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium24";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 23.98504d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    