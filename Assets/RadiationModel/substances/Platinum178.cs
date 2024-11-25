using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum178 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum178";
        public override double halfLife { get; } = 20.7d;
        public override double atomicWeight { get; } = 177.96565d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9229999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium178() }, { 1.0d, new BetaParticle(1, 5773500.0) } } },
            { 0.077d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium174() }, { 1.0d, new AlphaParticle(6595002.09) } } },

        };
    }
}
    