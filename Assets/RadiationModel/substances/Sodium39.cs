using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium39 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium39";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 39.07513d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    