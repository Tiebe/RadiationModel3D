using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel80 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel80";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 79.97505d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13440000.0), new Copper80() } },

        };
    }
}
    
    