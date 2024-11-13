
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium175m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium175m";
        public override double halfLife { get; } = 33.0d;
        public override double atomicWeight { get; } = 174.9642d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    