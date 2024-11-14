using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium262 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium262";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 262.10746d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    