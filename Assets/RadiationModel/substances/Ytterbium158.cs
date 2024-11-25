using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium158";
        public override double halfLife { get; } = 89.4d;
        public override double atomicWeight { get; } = 157.93987d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium158() }, { 1.0d, new BetaParticle(1, 4647000.0) }, { 0.00016d, new GammaParticle(511000.0, 0.00243) }, { 0.00017999999999999998d, new GammaParticle(8215.0, 0.15092) }, { 0.00021d, new GammaParticle(49773.0, 0.02491) }, { 0.0004d, new GammaParticle(50742.0, 0.02443) }, { 0.00012d, new GammaParticle(57612.0, 0.02152) }, { 0.00016d, new GammaParticle(58257.0, 0.02128) }, { 3e-05d, new GammaParticle(59034.0, 0.021) } } },
            { 2.1e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium154() }, { 1.0d, new AlphaParticle(5192002.09) } } },

        };
    }
}
    