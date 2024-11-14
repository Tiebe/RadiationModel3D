using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum188m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum188m";
        public override double halfLife { get; } = 19.6d;
        public override double atomicWeight { get; } = 187.9637d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    