
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon51 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon51";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 50.99303d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    