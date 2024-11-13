
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium251p : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium251p";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 251.08483d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    