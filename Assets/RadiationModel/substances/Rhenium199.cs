
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium199 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium199";
        public override double halfLife { get; } = 0.25d;
        public override double atomicWeight { get; } = 198.98419d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    