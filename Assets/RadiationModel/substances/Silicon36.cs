using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon36 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon36";
        public override double halfLife { get; } = 0.45d;
        public override double atomicWeight { get; } = 35.98665d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus36() }, { 1.0d, new BetaParticle(-1, 3905500.0) }, { 0.68d, new GammaParticle(175000.0, 0.00708) }, { 0.68d, new GammaParticle(249900.0, 0.00496) }, { 0.3196d, new GammaParticle(424900.0, 0.00292) }, { 0.442d, new GammaParticle(878200.0, 0.00141) }, { 0.1292d, new GammaParticle(921400.0, 0.00135) }, { 0.1292d, new GammaParticle(934700.0, 0.00133) }, { 0.0816d, new GammaParticle(977900.0, 0.00127) }, { 0.0204d, new GammaParticle(1053200.0, 0.00118) }, { 0.2788d, new GammaParticle(1856000.0, 0.00067) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus36() }, { 1.0d, new BetaParticle(-1, 3905500.0) }, { 0.68d, new GammaParticle(175000.0, 0.00708) }, { 0.68d, new GammaParticle(249900.0, 0.00496) }, { 0.3196d, new GammaParticle(424900.0, 0.00292) }, { 0.442d, new GammaParticle(878200.0, 0.00141) }, { 0.1292d, new GammaParticle(921400.0, 0.00135) }, { 0.1292d, new GammaParticle(934700.0, 0.00133) }, { 0.0816d, new GammaParticle(977900.0, 0.00127) }, { 0.0204d, new GammaParticle(1053200.0, 0.00118) }, { 0.2788d, new GammaParticle(1856000.0, 0.00067) } } },

        };
    }
}
    