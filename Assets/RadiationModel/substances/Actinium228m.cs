using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium228m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium228m";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 228.03159d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    