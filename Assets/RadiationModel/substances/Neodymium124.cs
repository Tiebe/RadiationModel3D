
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium124 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium124";
        public override double halfLife { get; } = 0.5d;
        public override double atomicWeight { get; } = 123.95187d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    