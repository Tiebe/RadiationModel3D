using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth201m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth201m";
        public override double halfLife { get; } = 3450.0d;
        public override double atomicWeight { get; } = 200.9779d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4688000.0), new Lead201() } },

        };
    }
}
    
    