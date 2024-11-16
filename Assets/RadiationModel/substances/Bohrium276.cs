using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium276 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium276";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 276.14917d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    