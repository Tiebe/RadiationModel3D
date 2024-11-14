using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium90";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 89.9047d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    