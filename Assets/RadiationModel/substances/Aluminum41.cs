
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum41 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum41";
        public override double halfLife { get; } = 0.006d;
        public override double atomicWeight { get; } = 41.03713d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    