
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum160m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum160m";
        public override double halfLife { get; } = 1.55d;
        public override double atomicWeight { get; } = 159.96166d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    