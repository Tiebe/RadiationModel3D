
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium167m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium167m";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 166.93829d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    