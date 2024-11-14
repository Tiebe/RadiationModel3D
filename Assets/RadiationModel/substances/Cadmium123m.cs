using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium123m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium123m";
        public override double halfLife { get; } = 1.82d;
        public override double atomicWeight { get; } = 122.91705d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    