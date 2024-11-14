using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt64m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt64m";
        public override double halfLife { get; } = 0.3d;
        public override double atomicWeight { get; } = 63.93592d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    