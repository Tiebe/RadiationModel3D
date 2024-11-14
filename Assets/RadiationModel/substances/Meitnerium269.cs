using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium269 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium269";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 269.13881d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    