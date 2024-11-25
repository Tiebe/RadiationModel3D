using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine201 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine201";
        public override double halfLife { get; } = 87.6d;
        public override double atomicWeight { get; } = 200.98842d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.71d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth197() }, { 1.0d, new AlphaParticle(7495002.09) } } },
            { 0.29d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth201() }, { 1.0d, new BetaParticle(1, 5320000.0) }, { 0.0034000000000000002d, new GammaParticle(358500.0, 0.00346) }, { 0.024d, new GammaParticle(417800.0, 0.00297) }, { 0.0098d, new GammaParticle(436200.0, 0.00284) }, { 0.004d, new GammaParticle(476600.0, 0.0026) }, { 0.027999999999999997d, new GammaParticle(491800.0, 0.00252) }, { 0.033d, new GammaParticle(492700.0, 0.00252) }, { 0.032d, new GammaParticle(537000.0, 0.00231) }, { 0.015d, new GammaParticle(559100.0, 0.00222) }, { 0.048d, new GammaParticle(583300.0, 0.00213) }, { 0.085d, new GammaParticle(591800.0, 0.0021) }, { 0.016d, new GammaParticle(616100.0, 0.00201) }, { 0.009000000000000001d, new GammaParticle(621600.0, 0.00199) }, { 0.0121d, new GammaParticle(628600.0, 0.00197) }, { 0.0060999999999999995d, new GammaParticle(716600.0, 0.00173) }, { 0.028999999999999998d, new GammaParticle(722500.0, 0.00172) }, { 0.02d, new GammaParticle(758300.0, 0.00164) }, { 0.059000000000000004d, new GammaParticle(760700.0, 0.00163) }, { 0.19920000000000002d, new GammaParticle(511000.0, 0.00243) }, { 0.10768996601401999d, new GammaParticle(13292.0, 0.09328) }, { 0.06891423022990086d, new GammaParticle(76862.0, 0.01613) }, { 0.11476141586994312d, new GammaParticle(79290.0, 0.01564) }, { 0.03950917787960031d, new GammaParticle(89837.0, 0.0138) }, { 0.051796532200156d, new GammaParticle(90941.0, 0.01363) }, { 0.012287354320555697d, new GammaParticle(92315.0, 0.01343) } } },

        };
    }
}
    