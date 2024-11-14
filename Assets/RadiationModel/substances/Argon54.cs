using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon54 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon54";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 54.01348d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    