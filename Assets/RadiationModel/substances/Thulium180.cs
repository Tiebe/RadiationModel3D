
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium180 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium180";
        public override double halfLife { get; } = 3.0d;
        public override double atomicWeight { get; } = 179.95902d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    