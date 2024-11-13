
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium277p : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium277p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 277.15244d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    