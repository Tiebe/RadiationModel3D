
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium280 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium280";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 280.1671d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    