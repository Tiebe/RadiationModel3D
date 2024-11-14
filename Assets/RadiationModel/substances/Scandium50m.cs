using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium50m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium50m";
        public override double halfLife { get; } = 0.35d;
        public override double atomicWeight { get; } = 49.95246d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99d, new List<RadioactiveSubstance> { new GammaParticle(0.00483), new Scandium50() } },
            { 0.01d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7151670.0), new Titanium50() } },

        };
    }
}
    
    