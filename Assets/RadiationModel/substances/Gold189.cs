using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold189 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold189";
        public override double halfLife { get; } = 1722.0d;
        public override double atomicWeight { get; } = 188.96395d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium189() }, { 1.0d, new BetaParticle(1, 2434000.0) } } },
            { 3e-07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium185() }, { 1.0d, new AlphaParticle(5351002.09) } } },

        };
    }
}
    