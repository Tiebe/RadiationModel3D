
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium209";
        public override double halfLife { get; } = 0.06d;
        public override double atomicWeight { get; } = 209.01761d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    