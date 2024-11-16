using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium264 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium264";
        public override double halfLife { get; } = 36000.0d;
        public override double atomicWeight { get; } = 264.1142d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    