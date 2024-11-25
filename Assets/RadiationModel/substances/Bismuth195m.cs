using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth195m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth195m";
        public override double halfLife { get; } = 87.0d;
        public override double atomicWeight { get; } = 194.98108d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.67d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium195() }, { 1.0d, new BetaParticle(1, 5264500.0) } } },
            { 0.33d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium191() }, { 1.0d, new AlphaParticle(7254002.09) } } },

        };
    }
}
    