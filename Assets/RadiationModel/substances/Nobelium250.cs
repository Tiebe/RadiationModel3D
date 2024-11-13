
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium250 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium250";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 250.08757d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    