using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium150";
        public override double halfLife { get; } = 0.7d;
        public override double atomicWeight { get; } = 149.95831d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    