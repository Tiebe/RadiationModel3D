
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium248 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium248";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 248.07575d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    