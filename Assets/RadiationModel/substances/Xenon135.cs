using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon135 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon135";
        public override double halfLife { get; } = 32904.0d;
        public override double atomicWeight { get; } = 134.90723d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium135() }, { 1.0d, new BetaParticle(-1, 584500.0) }, { 0.002889d, new GammaParticle(158197.0, 0.00784) }, { 0.000117d, new GammaParticle(200190.0, 0.00619) }, { 0.9d, new GammaParticle(249794.0, 0.00496) }, { 0.002205d, new GammaParticle(358390.0, 0.00346) }, { 0.000153d, new GammaParticle(373130.0, 0.00332) }, { 0.003582d, new GammaParticle(407990.0, 0.00304) }, { 3.6e-05d, new GammaParticle(454200.0, 0.00273) }, { 4.77e-05d, new GammaParticle(573320.0, 0.00216) }, { 0.028980000000000002d, new GammaParticle(608185.0, 0.00204) }, { 0.00045d, new GammaParticle(654432.0, 0.00189) }, { 0.000549d, new GammaParticle(731520.0, 0.00169) }, { 0.0007019999999999999d, new GammaParticle(812630.0, 0.00153) }, { 4.0499999999999995e-05d, new GammaParticle(1062410.0, 0.00117) }, { 0.006095485488455999d, new GammaParticle(4749.0, 0.26107) }, { 0.014304131742087627d, new GammaParticle(30625.0, 0.04048) }, { 0.02642551587306046d, new GammaParticle(30973.0, 0.04003) }, { 0.0077202981572764605d, new GammaParticle(35089.0, 0.03533) }, { 0.009604050907651918d, new GammaParticle(35414.0, 0.03501) }, { 0.0018837527503754565d, new GammaParticle(35818.0, 0.03462) } } },

        };
    }
}
    