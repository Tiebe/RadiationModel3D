
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium61 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium61";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 61.02041d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    