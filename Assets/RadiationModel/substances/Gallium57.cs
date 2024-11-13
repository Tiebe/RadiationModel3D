
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium57 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium57";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 56.98346d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    