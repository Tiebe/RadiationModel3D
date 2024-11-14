using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Moscovium291 : RadioactiveSubstance
    {
        public override string name { get; } = "Moscovium291";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 291.19773d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    