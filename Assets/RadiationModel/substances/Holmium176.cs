
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium176 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium176";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 175.95771d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    