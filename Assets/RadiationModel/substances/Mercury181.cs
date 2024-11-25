using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury181 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury181";
        public override double halfLife { get; } = 3.6d;
        public override double atomicWeight { get; } = 180.97782d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.73d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum181() }, { 1.0d, new BetaParticle(1, 6860000.0) } } },
            { 0.27d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum177() }, { 1.0d, new AlphaParticle(7306002.09) } } },
            { 0.00013d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum180() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    