
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium241 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium241";
        public override double halfLife { get; } = 276.0d;
        public override double atomicWeight { get; } = 241.0601d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    