using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium205 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium205";
        public override double halfLife { get; } = 3.9d;
        public override double atomicWeight { get; } = 204.99859d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.985d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine201() }, { 1.0d, new AlphaParticle(8076002.09) } } },
            { 0.015d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine205() }, { 1.0d, new BetaParticle(1, 5837500.0) }, { 6.0400000000000004e-05d, new GammaParticle(31400.0, 0.03949) }, { 0.0016d, new GammaParticle(356300.0, 0.00348) }, { 0.0011d, new GammaParticle(387500.0, 0.0032) }, { 0.0010199999999999999d, new GammaParticle(503800.0, 0.00246) }, { 0.003d, new GammaParticle(545300.0, 0.00227) }, { 0.003d, new GammaParticle(564700.0, 0.0022) }, { 0.0013d, new GammaParticle(596300.0, 0.00208) }, { 0.002d, new GammaParticle(633100.0, 0.00196) }, { 0.0011d, new GammaParticle(657100.0, 0.00189) }, { 0.01324d, new GammaParticle(511000.0, 0.00243) }, { 0.004946863009632d, new GammaParticle(14088.0, 0.08801) }, { 0.0022590855058120594d, new GammaParticle(81070.0, 0.01529) }, { 0.003726633958779379d, new GammaParticle(83789.0, 0.0148) }, { 0.001292371248036788d, new GammaParticle(94878.0, 0.01307) }, { 0.0017059300474085602d, new GammaParticle(96054.0, 0.01291) }, { 0.0004135587993717722d, new GammaParticle(97530.0, 0.01271) } } },

        };
    }
}
    