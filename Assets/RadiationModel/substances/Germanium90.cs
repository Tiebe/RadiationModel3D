using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium90";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 89.96944d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    