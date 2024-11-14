using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium199 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium199";
        public override double halfLife { get; } = 26712.0d;
        public override double atomicWeight { get; } = 198.96988d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1487100.0), new Mercury199() } },

        };
    }
}
    
    