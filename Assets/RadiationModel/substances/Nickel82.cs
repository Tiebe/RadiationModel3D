using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel82 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel82";
        public override double halfLife { get; } = 0.016d;
        public override double atomicWeight { get; } = 81.98849d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    