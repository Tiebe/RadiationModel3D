using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium156m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium156m";
        public override double halfLife { get; } = 19080.0d;
        public override double atomicWeight { get; } = 155.92485d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    