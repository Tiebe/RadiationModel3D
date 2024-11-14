using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium166p : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium166p";
        public override double halfLife { get; } = 3.0d;
        public override double atomicWeight { get; } = 165.96612d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    