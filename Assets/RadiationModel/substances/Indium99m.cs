
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium99m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium99m";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 98.93454d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    