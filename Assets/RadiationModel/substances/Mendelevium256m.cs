using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium256m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium256m";
        public override double halfLife { get; } = 6000.0d;
        public override double atomicWeight { get; } = 256.09406d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    