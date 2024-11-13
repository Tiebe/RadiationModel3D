
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten194 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten194";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 193.97379d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    