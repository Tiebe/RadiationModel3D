using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium156m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium156m";
        public override double halfLife { get; } = 2.3d;
        public override double atomicWeight { get; } = 155.93128d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.98d, new List<RadioactiveSubstance> { new GammaParticle(0.00825), new Promethium156() } },
            { 0.02d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5344500.0), new Samarium156() } },

        };
    }
}
    
    