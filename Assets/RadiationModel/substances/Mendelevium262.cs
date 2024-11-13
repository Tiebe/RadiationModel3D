
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium262 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium262";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 262.10915d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    