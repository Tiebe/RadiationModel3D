using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury185 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury185";
        public override double halfLife { get; } = 49.1d;
        public override double atomicWeight { get; } = 184.97189d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum185() }, { 1.0d, new BetaParticle(1, 5252000.0) } } },
            { 0.06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum181() }, { 1.0d, new AlphaParticle(6794002.09) } } },

        };
    }
}
    