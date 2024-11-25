using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium32 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium32";
        public override double halfLife { get; } = 0.0132d;
        public override double atomicWeight { get; } = 32.02001d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium32() }, { 1.0d, new BetaParticle(-1, 9734500.0) }, { 0.00754d, new GammaParticle(486100.0, 0.00255) }, { 0.04002d, new GammaParticle(693500.0, 0.00179) }, { 0.58d, new GammaParticle(885200.0, 0.0014) }, { 0.02204d, new GammaParticle(1231700.0, 0.00101) }, { 0.02204d, new GammaParticle(1231700.0, 0.00101) }, { 0.05684d, new GammaParticle(1436100.0, 0.00086) }, { 0.013919999999999998d, new GammaParticle(1665600.0, 0.00074) }, { 0.052199999999999996d, new GammaParticle(1782700.0, 0.0007) }, { 0.06727999999999999d, new GammaParticle(1972900.0, 0.00063) }, { 0.2726d, new GammaParticle(2151500.0, 0.00058) }, { 0.014499999999999999d, new GammaParticle(2268500.0, 0.00055) }, { 0.03712d, new GammaParticle(2550700.0, 0.00049) }, { 0.00638d, new GammaParticle(2869200.0, 0.00043) }, { 0.01914d, new GammaParticle(2925800.0, 0.00042) }, { 0.0696d, new GammaParticle(3934500.0, 0.00032) }, { 0.013919999999999998d, new GammaParticle(4575000.0, 0.00027) }, { 0.01914d, new GammaParticle(5470000.0, 0.00023) } } },
            { 0.24d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium32() }, { 1.0d, new BetaParticle(-1, 9734500.0) }, { 0.00754d, new GammaParticle(486100.0, 0.00255) }, { 0.04002d, new GammaParticle(693500.0, 0.00179) }, { 0.58d, new GammaParticle(885200.0, 0.0014) }, { 0.02204d, new GammaParticle(1231700.0, 0.00101) }, { 0.02204d, new GammaParticle(1231700.0, 0.00101) }, { 0.05684d, new GammaParticle(1436100.0, 0.00086) }, { 0.013919999999999998d, new GammaParticle(1665600.0, 0.00074) }, { 0.052199999999999996d, new GammaParticle(1782700.0, 0.0007) }, { 0.06727999999999999d, new GammaParticle(1972900.0, 0.00063) }, { 0.2726d, new GammaParticle(2151500.0, 0.00058) }, { 0.014499999999999999d, new GammaParticle(2268500.0, 0.00055) }, { 0.03712d, new GammaParticle(2550700.0, 0.00049) }, { 0.00638d, new GammaParticle(2869200.0, 0.00043) }, { 0.01914d, new GammaParticle(2925800.0, 0.00042) }, { 0.0696d, new GammaParticle(3934500.0, 0.00032) }, { 0.013919999999999998d, new GammaParticle(4575000.0, 0.00027) }, { 0.01914d, new GammaParticle(5470000.0, 0.00023) } } },
            { 0.083d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium30() }, { 1.0d, new BetaParticle(-1, 945254803.472) }, { 1.0d, new NeutronParticle() }, { 0.018000000000000002d, new GammaParticle(1482400.0, 0.00084) } } },

        };
    }
}
    