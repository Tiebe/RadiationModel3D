
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver127m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver127m";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 126.93706d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    