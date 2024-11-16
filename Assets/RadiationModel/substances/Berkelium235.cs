using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium235";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 235.05665d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    