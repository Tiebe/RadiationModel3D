using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium122";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 121.93787d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    