
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium21i : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium21i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 21.00729d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    