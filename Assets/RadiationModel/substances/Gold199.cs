using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold199 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold199";
        public override double halfLife { get; } = 271209.6d;
        public override double atomicWeight { get; } = 198.96877d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury199() }, { 1.0d, new BetaParticle(-1, 226149.99999) }, { 0.003604d, new GammaParticle(49826.35, 0.02488) }, { 0.4d, new GammaParticle(158378.51, 0.00783) }, { 0.0872d, new GammaParticle(208204.81, 0.00595) }, { 0.133348782628d, new GammaParticle(11777.0, 0.10528) }, { 0.05143804860036347d, new GammaParticle(68894.0, 0.018) }, { 0.08719791252816318d, new GammaParticle(70820.0, 0.01751) }, { 0.029592826969430285d, new GammaParticle(80316.0, 0.01544) }, { 0.03826352527147336d, new GammaParticle(81285.0, 0.01525) }, { 0.008670698302043074d, new GammaParticle(82477.0, 0.01503) } } },

        };
    }
}
    