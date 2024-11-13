
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium73m : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium73m";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 72.92517d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    