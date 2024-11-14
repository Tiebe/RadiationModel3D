using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium140";
        public override double halfLife { get; } = 0.006d;
        public override double atomicWeight { get; } = 139.96852d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    