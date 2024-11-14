using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus45 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus45";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 45.01713d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    