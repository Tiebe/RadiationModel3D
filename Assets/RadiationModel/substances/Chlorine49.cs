
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine49 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine49";
        public override double halfLife { get; } = 0.035d;
        public override double atomicWeight { get; } = 49.00079d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    