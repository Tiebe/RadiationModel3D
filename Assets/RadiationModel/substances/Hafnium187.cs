using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium187 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium187";
        public override double halfLife { get; } = 14.0d;
        public override double atomicWeight { get; } = 186.96457d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    