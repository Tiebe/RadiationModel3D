
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium228 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium228";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 228.046d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    