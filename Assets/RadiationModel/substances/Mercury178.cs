using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury178 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury178";
        public override double halfLife { get; } = 0.2665d;
        public override double atomicWeight { get; } = 177.98249d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum174() }, { 1.0d, new AlphaParticle(7600002.09) } } },
            { 0.3d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum178() }, { 1.0d, new BetaParticle(1, 7841000.0) } } },

        };
    }
}
    