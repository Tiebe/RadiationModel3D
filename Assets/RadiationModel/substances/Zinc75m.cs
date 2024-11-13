
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc75m : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc75m";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 74.93298d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    