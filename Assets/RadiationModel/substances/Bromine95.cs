
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine95 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine95";
        public override double halfLife { get; } = 0.08d;
        public override double atomicWeight { get; } = 94.95293d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    