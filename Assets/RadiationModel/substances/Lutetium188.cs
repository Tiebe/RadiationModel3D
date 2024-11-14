using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium188 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium188";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 187.97443d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    