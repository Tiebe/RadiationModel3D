using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth195 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth195";
        public override double halfLife { get; } = 183.0d;
        public override double atomicWeight { get; } = 194.98065d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5712000.0), new Lead195() } },
            { 0.0003d, new List<RadioactiveSubstance> { new AlphaParticle(6854002.09), new Thallium191() } },

        };
    }
}
    
    