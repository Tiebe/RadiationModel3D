using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium153";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 152.97069d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    