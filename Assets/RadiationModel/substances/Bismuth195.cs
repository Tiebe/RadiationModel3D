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

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9997d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium195() }, { 1.0d, new BetaParticle(1, 5064500.0) } } },
            { 0.0003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium191() }, { 1.0d, new AlphaParticle(6854002.09) } } },

        };
    }
}
    