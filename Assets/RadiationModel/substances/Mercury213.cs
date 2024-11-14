using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury213 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury213";
        public override double halfLife { get; } = 15.0d;
        public override double atomicWeight { get; } = 213.0088d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    