using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium234n : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium234n";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 234.0488d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    