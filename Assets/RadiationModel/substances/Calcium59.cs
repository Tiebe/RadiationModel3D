
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium59 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium59";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 59.00624d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    