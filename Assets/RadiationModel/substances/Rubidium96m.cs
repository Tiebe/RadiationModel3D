
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium96m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium96m";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 95.93414d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    