using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium60m : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium60m";
        public override double halfLife { get; } = 0.04d;
        public override double atomicWeight { get; } = 59.96448d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    