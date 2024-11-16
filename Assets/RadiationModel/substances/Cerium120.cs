using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium120";
        public override double halfLife { get; } = 0.25d;
        public override double atomicWeight { get; } = 119.94661d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    