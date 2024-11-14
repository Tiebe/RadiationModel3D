using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium277 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium277";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 277.15148d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    