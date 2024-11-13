
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium234m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium234m";
        public override double halfLife { get; } = 93.0d;
        public override double atomicWeight { get; } = 234.04829d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    