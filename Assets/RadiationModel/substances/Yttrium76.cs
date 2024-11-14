using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium76 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium76";
        public override double halfLife { get; } = 0.028d;
        public override double atomicWeight { get; } = 75.95894d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    