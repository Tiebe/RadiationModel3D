
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium174m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium174m";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 173.95323d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    