
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium143m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium143m";
        public override double halfLife { get; } = 17.0d;
        public override double atomicWeight { get; } = 142.93514d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    