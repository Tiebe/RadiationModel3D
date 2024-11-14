using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium77 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium77";
        public override double halfLife { get; } = 9.0d;
        public override double atomicWeight { get; } = 76.93795d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7027500.0), new Rubidium77() } },

        };
    }
}
    
    