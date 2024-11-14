using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium197m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium197m";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 196.97361d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    