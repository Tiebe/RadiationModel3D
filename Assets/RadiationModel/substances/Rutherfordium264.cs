
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium264 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium264";
        public override double halfLife { get; } = 3600.0d;
        public override double atomicWeight { get; } = 264.11388d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    