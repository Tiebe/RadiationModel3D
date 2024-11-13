
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium263 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium263";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 263.12292d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    