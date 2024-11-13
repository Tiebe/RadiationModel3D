
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium151";
        public override double halfLife { get; } = 0.0784d;
        public override double atomicWeight { get; } = 150.96747d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    