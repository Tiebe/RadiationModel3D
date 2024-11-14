using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium128";
        public override double halfLife { get; } = 0.008d;
        public override double atomicWeight { get; } = 127.97065d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    