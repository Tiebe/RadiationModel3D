
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium126 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium126";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 125.94269d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    