using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium137";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 136.95602d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    