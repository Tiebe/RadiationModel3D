using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus27 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus27";
        public override double halfLife { get; } = 0.26d;
        public override double atomicWeight { get; } = 26.99929d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum27() }, { 1.0d, new BetaParticle(1, 8268930.0) } } },
            { 0.0007000000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum26() }, { 1.0d, new BetaParticle(1, 471522621.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    