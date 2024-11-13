
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium89";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 88.90584d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    