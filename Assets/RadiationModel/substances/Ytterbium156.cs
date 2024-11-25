using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium156";
        public override double halfLife { get; } = 26.1d;
        public override double atomicWeight { get; } = 155.94282d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium156() }, { 1.0d, new BetaParticle(1, 5473000.0) }, { 0.53d, new GammaParticle(115200.0, 0.01076) }, { 0.024d, new GammaParticle(202300.0, 0.00613) }, { 0.418d, new GammaParticle(511000.0, 0.00243) }, { 0.10606008294500001d, new GammaParticle(8215.0, 0.15092) }, { 0.12760291030888565d, new GammaParticle(49773.0, 0.02491) }, { 0.22528762413291958d, new GammaParticle(50742.0, 0.02443) }, { 0.07365889726840855d, new GammaParticle(57612.0, 0.02152) }, { 0.09281021055819477d, new GammaParticle(58257.0, 0.02128) }, { 0.019151313289786222d, new GammaParticle(59034.0, 0.021) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium152() }, { 1.0d, new AlphaParticle(5831002.09) } } },

        };
    }
}
    