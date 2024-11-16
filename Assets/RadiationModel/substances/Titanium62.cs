using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium62 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium62";
        public override double halfLife { get; } = 0.009d;
        public override double atomicWeight { get; } = 61.9869d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    