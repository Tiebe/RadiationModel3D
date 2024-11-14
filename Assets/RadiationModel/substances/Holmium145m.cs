using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium145m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium145m";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 144.94737d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    