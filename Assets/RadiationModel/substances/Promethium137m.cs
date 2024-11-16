using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium137m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium137m";
        public override double halfLife { get; } = 144.0d;
        public override double atomicWeight { get; } = 136.92065d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5674000.0), new Neodymium137() } },

        };
    }
}
    
    