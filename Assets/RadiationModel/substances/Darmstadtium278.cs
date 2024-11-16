using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium278 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium278";
        public override double halfLife { get; } = 0.27d;
        public override double atomicWeight { get; } = 278.15701d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    