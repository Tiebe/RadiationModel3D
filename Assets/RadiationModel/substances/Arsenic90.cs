using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic90 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic90";
        public override double halfLife { get; } = 0.07d;
        public override double atomicWeight { get; } = 89.956d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    