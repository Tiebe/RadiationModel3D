using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth224 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth224";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 224.0398d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    