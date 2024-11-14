using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium138";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 137.9625d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    