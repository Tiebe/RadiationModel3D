using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium149m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium149m";
        public override double halfLife { get; } = 0.5d;
        public override double atomicWeight { get; } = 148.95294d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    