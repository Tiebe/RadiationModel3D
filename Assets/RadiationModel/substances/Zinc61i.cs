using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc61i : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc61i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 60.9429d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    