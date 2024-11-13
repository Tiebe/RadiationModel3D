
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium180 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium180";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 179.96438d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    