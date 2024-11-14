using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium134";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 133.95542d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    