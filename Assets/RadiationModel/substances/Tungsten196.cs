
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten196 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten196";
        public override double halfLife { get; } = 25.0d;
        public override double atomicWeight { get; } = 195.97988d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    