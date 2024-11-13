
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium162m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium162m";
        public override double halfLife { get; } = 600.0d;
        public override double atomicWeight { get; } = 161.92958d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    