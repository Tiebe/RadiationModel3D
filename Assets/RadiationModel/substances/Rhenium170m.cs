using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium170m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium170m";
        public override double halfLife { get; } = 9.2d;
        public override double atomicWeight { get; } = 169.95831d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    