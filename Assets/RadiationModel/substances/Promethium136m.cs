using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium136m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium136m";
        public override double halfLife { get; } = 90.0d;
        public override double atomicWeight { get; } = 135.9237d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8129000.0), new Neodymium136() } },

        };
    }
}
    
    