using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon150 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon150";
        public override double halfLife { get; } = 0.04d;
        public override double atomicWeight { get; } = 149.96888d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    