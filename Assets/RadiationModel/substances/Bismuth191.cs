using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth191 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth191";
        public override double halfLife { get; } = 12.4d;
        public override double atomicWeight { get; } = 190.98579d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.51d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium187() }, { 1.0d, new AlphaParticle(7803002.09) } } },
            { 0.49d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium191() }, { 1.0d, new BetaParticle(1, 6522000.0) } } },

        };
    }
}
    