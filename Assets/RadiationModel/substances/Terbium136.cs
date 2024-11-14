using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium136 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium136";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 135.96146d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    