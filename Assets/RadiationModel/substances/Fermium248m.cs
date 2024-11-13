
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium248m : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium248m";
        public override double halfLife { get; } = 0.0101d;
        public override double atomicWeight { get; } = 248.07848d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    