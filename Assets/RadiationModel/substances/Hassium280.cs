
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium280 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium280";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 280.15934d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    