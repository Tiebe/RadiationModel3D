
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium176 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium176";
        public override double halfLife { get; } = 12.0d;
        public override double atomicWeight { get; } = 175.94994d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    