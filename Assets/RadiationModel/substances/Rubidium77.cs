using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium77 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium77";
        public override double halfLife { get; } = 226.8d;
        public override double atomicWeight { get; } = 76.9304d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5339000.0), new Krypton77() } },

        };
    }
}
    
    