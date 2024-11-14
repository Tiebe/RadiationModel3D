using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury191m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury191m";
        public override double halfLife { get; } = 3048.0d;
        public override double atomicWeight { get; } = 190.9673d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3338000.0), new Gold191() } },

        };
    }
}
    
    