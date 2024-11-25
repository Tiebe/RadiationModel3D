using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium125";
        public override double halfLife { get; } = 198.0d;
        public override double atomicWeight { get; } = 124.91447d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon125() }, { 1.0d, new BetaParticle(1, 3765200.0) } } },

        };
    }
}
    