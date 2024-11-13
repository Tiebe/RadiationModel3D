
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium223";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 223.03878d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    