
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium218 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium218";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 218.02545d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    