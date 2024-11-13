
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium153m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium153m";
        public override double halfLife { get; } = 0.5d;
        public override double atomicWeight { get; } = 152.9715d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    