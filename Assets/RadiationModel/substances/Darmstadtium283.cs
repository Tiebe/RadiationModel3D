
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium283 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium283";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 283.16944d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    