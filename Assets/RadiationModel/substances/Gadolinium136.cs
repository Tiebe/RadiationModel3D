using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium136 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium136";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 135.9473d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    