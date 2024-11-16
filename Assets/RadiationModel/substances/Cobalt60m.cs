using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt60m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt60m";
        public override double halfLife { get; } = 628.02d;
        public override double atomicWeight { get; } = 59.93388d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9975d, new List<RadioactiveSubstance> { new GammaParticle(0.02116), new Cobalt60() } },
            { 0.0025d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2881400.0), new Nickel60() } },

        };
    }
}
    
    