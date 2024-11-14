using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium173";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 172.9608d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    