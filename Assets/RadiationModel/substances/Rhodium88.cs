
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium88";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 87.96043d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    