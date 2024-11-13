
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium158m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium158m";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 157.93709d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    