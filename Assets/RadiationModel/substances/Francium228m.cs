
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium228m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium228m";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 228.03692d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    