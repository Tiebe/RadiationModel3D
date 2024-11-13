
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium239";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 239.06831d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    