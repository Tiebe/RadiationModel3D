
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc86 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc86";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 85.97846d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    