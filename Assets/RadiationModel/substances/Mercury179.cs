using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury179 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury179";
        public override double halfLife { get; } = 1.05d;
        public override double atomicWeight { get; } = 178.98182d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.55d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum175() }, { 1.0d, new AlphaParticle(7373002.09) } } },
            { 0.45d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum179() }, { 1.0d, new BetaParticle(1, 7667500.0) } } },
            { 0.0015d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum178() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    