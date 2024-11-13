
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium190 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium190";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 189.97338d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    