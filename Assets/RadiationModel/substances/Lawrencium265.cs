using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium265 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium265";
        public override double halfLife { get; } = 36000.0d;
        public override double atomicWeight { get; } = 265.11619d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    