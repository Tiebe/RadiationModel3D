using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium253 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium253";
        public override double halfLife { get; } = 3600.0d;
        public override double atomicWeight { get; } = 253.08688d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    