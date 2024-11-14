using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium87m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium87m";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 86.93807d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    