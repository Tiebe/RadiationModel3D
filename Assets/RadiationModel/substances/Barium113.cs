using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium113";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 112.95737d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    