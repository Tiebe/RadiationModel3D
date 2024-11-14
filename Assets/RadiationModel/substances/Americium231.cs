using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium231";
        public override double halfLife { get; } = 60.0d;
        public override double atomicWeight { get; } = 231.04553d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    