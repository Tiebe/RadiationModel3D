
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth223 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth223";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 223.03461d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    