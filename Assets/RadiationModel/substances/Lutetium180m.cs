
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium180m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium180m";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 179.9499d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    