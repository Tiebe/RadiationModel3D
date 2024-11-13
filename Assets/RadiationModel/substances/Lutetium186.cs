
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium186 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium186";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 185.96745d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    