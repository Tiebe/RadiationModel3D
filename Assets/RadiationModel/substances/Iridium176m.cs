
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium176m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium176m";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 175.96368d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    