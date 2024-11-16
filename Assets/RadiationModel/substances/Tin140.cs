using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin140 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin140";
        public override double halfLife { get; } = 0.05d;
        public override double atomicWeight { get; } = 139.96297d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    