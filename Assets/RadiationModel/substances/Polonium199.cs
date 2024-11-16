using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium199 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium199";
        public override double halfLife { get; } = 328.2d;
        public override double atomicWeight { get; } = 198.98364d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.925d, new List<RadioactiveSubstance> { new BetaParticle(1, 5559000.0), new Bismuth199() } },
            { 0.075d, new List<RadioactiveSubstance> { new AlphaParticle(7094047.4), new Lead195() } },

        };
    }
}
    
    