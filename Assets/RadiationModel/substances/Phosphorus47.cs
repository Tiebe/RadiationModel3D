
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus47 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus47";
        public override double halfLife { get; } = 0.004d;
        public override double atomicWeight { get; } = 47.03093d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    