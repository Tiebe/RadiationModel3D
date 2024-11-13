
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium185 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium185";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 184.96354d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    