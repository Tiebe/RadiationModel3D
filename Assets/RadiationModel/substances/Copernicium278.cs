
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium278 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium278";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 278.16408d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    