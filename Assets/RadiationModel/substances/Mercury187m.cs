using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury187m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury187m";
        public override double halfLife { get; } = 144.0d;
        public override double atomicWeight { get; } = 186.96988d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4969000.0), new Gold187() } },

        };
    }
}
    
    