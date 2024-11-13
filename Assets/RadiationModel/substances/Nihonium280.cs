
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium280 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium280";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 280.1731d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    