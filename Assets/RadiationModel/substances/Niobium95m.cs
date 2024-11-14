using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium95m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium95m";
        public override double halfLife { get; } = 311904.0d;
        public override double atomicWeight { get; } = 94.90708d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9440000000000001d, new List<RadioactiveSubstance> { new GammaParticle(0.00526), new Niobium95() } },
            { 0.055999999999999994d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1161270.0), new Molybdenum95() } },

        };
    }
}
    
    