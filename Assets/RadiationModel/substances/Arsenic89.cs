using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic89 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic89";
        public override double halfLife { get; } = 0.22d;
        public override double atomicWeight { get; } = 88.95005d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    