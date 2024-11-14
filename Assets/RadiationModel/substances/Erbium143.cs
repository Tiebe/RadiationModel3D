using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium143";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 142.96655d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    