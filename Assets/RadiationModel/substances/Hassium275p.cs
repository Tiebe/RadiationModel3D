using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium275p : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium275p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 275.14681d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    