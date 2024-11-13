
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon201m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon201m";
        public override double halfLife { get; } = 3.8d;
        public override double atomicWeight { get; } = 200.99585d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    