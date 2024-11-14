using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium174";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 173.95585d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    