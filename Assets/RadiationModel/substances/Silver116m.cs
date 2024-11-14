using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver116m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver116m";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 115.91144d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.93d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6217490.0), new Cadmium116() } },
            { 0.07d, new List<RadioactiveSubstance> { new GammaParticle(0.02583), new Silver116() } },

        };
    }
}
    
    