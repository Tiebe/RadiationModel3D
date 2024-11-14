using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium242m : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium242m";
        public override double halfLife { get; } = 330.0d;
        public override double atomicWeight { get; } = 242.0617d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2753100.0), new Plutonium242() } },

        };
    }
}
    
    