using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium131";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 130.97237d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    