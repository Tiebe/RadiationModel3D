using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver125m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver125m";
        public override double halfLife { get; } = 0.05d;
        public override double atomicWeight { get; } = 124.93084d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    