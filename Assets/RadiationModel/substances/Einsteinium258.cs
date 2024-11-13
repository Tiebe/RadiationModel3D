
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium258";
        public override double halfLife { get; } = 240.0d;
        public override double atomicWeight { get; } = 258.09952d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    