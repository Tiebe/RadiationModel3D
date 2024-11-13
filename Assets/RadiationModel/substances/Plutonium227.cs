
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium227 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium227";
        public override double halfLife { get; } = 2.0d;
        public override double atomicWeight { get; } = 227.03947d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    