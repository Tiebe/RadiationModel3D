
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum206 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum206";
        public override double halfLife { get; } = 0.5d;
        public override double atomicWeight { get; } = 205.99008d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    