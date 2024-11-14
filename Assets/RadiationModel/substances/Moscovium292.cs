using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Moscovium292 : RadioactiveSubstance
    {
        public override string name { get; } = "Moscovium292";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 292.20032d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    