
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver120m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver120m";
        public override double halfLife { get; } = 0.94d;
        public override double atomicWeight { get; } = 119.91879d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    