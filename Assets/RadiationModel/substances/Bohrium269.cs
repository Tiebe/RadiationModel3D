
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium269 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium269";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 269.13041d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    