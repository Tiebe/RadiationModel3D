
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon52 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon52";
        public override double halfLife { get; } = 0.04d;
        public override double atomicWeight { get; } = 51.99852d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    