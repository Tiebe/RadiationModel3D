
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine114m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine114m";
        public override double halfLife { get; } = 6.2d;
        public override double atomicWeight { get; } = 113.9223d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    