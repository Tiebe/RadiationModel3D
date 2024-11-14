using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium67 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium67";
        public override double halfLife { get; } = 0.008d;
        public override double atomicWeight { get; } = 66.99813d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    