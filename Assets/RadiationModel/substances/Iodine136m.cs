using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine136m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine136m";
        public override double halfLife { get; } = 46.6d;
        public override double atomicWeight { get; } = 135.91483d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon136() }, { 1.0d, new BetaParticle(-1, 3545085.0) }, { 0.0043d, new GammaParticle(164120.0, 0.00755) }, { 0.0074d, new GammaParticle(182700.0, 0.00679) }, { 0.7829999999999999d, new GammaParticle(197316.0, 0.00628) }, { 0.0051d, new GammaParticle(318600.0, 0.00389) }, { 0.0026d, new GammaParticle(339400.0, 0.00365) }, { 0.0301d, new GammaParticle(346810.0, 0.00357) }, { 0.175d, new GammaParticle(369813.0, 0.00335) }, { 0.998d, new GammaParticle(381359.0, 0.00325) }, { 0.0063d, new GammaParticle(431380.0, 0.00287) }, { 0.0175d, new GammaParticle(482800.0, 0.00257) }, { 0.0084d, new GammaParticle(552690.0, 0.00224) }, { 0.0098d, new GammaParticle(716700.0, 0.00173) }, { 0.057999999999999996d, new GammaParticle(750050.0, 0.00165) }, { 0.0128d, new GammaParticle(770750.0, 0.00161) }, { 0.026000000000000002d, new GammaParticle(812630.0, 0.00153) }, { 0.035d, new GammaParticle(914100.0, 0.00136) }, { 1.0d, new GammaParticle(1313020.0, 0.00094) }, { 0.0018d, new GammaParticle(1385600.0, 0.00089) }, { 0.0025d, new GammaParticle(1592800.0, 0.00078) }, { 0.0069d, new GammaParticle(1796000.0, 0.00069) }, { 0.0021d, new GammaParticle(1937400.0, 0.00064) }, { 0.0069d, new GammaParticle(2135800.0, 0.00058) }, { 0.0007000000000000001d, new GammaParticle(2165800.0, 0.00057) }, { 0.0088d, new GammaParticle(2178400.0, 0.00057) }, { 0.0040999999999999995d, new GammaParticle(2362800.0, 0.00052) }, { 0.00062d, new GammaParticle(3600000.0, 0.00034) }, { 0.00089d, new GammaParticle(3735900.0, 0.00033) }, { 0.0003d, new GammaParticle(4396300.0, 0.00028) }, { 0.014175942586d, new GammaParticle(4540.0, 0.27309) }, { 0.03223413600252959d, new GammaParticle(29458.0, 0.04209) }, { 0.05971496110138865d, new GammaParticle(29778.0, 0.04164) }, { 0.017311128556700466d, new GammaParticle(33726.0, 0.03676) }, { 0.021396554896081773d, new GammaParticle(34030.0, 0.03643) }, { 0.00408542633938131d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    