using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium133m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium133m";
        public override double halfLife { get; } = 70.0d;
        public override double atomicWeight { get; } = 132.92249d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    