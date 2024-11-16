using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium250m : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium250m";
        public override double halfLife { get; } = 42.4d;
        public override double atomicWeight { get; } = 250.08429d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    