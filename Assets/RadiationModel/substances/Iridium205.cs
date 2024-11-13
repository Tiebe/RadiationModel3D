
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium205 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium205";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 204.99399d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    