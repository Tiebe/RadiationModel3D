using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copernicium287 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium287";
        public override double halfLife { get; } = 30.0d;
        public override double atomicWeight { get; } = 287.18183d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    