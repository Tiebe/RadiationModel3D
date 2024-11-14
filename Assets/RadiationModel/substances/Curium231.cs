using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium231";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 231.05075d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    