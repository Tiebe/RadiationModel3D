
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury215 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury215";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 215.01837d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    