using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium149m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium149m";
        public override double halfLife { get; } = 56.0d;
        public override double atomicWeight { get; } = 148.93387d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6097000.0), new Dysprosium149() } },

        };
    }
}
    
    