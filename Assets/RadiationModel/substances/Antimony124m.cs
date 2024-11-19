using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony124m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony124m";
        public override double halfLife { get; } = 93.0d;
        public override double atomicWeight { get; } = 123.90595d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new List<RadioactiveSubstance> { new GammaParticle((10899.99999, 0.11375)), new Antimony124() } },
            { 0.25d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2915900.0), new Tellurium124() } },

        };
    }
}
    
    