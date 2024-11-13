
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium203 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium203";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 202.98457d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    