using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury183m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury183m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 182.97466d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    