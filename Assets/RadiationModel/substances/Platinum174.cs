using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum174 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum174";
        public override double halfLife { get; } = 0.889d;
        public override double atomicWeight { get; } = 173.97282d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.76d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium170() }, { 1.0d, new AlphaParticle(7205002.09) } } },
            { 0.24d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium174() }, { 1.0d, new BetaParticle(1, 7338500.0) } } },

        };
    }
}
    