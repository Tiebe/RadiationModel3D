using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine140 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine140";
        public override double halfLife { get; } = 0.86d;
        public override double atomicWeight { get; } = 139.93172d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon140() }, { 1.0d, new BetaParticle(-1, 4690250.0) }, { 0.006999999999999999d, new GammaParticle(258600.0, 0.00479) }, { 0.013000000000000001d, new GammaParticle(355000.0, 0.00349) }, { 0.98d, new GammaParticle(376657.0, 0.00329) }, { 0.68d, new GammaParticle(457630.0, 0.00271) }, { 0.09300000000000001d, new GammaParticle(582400.0, 0.00213) }, { 0.017d, new GammaParticle(678700.0, 0.00183) }, { 0.188d, new GammaParticle(937400.0, 0.00132) }, { 0.044000000000000004d, new GammaParticle(1136700.0, 0.00109) }, { 0.00252d, new GammaParticle(4540.0, 0.27309) }, { 0.0062d, new GammaParticle(29458.0, 0.04209) }, { 0.0115d, new GammaParticle(29778.0, 0.04164) }, { 0.00333d, new GammaParticle(33726.0, 0.03676) }, { 0.0041199999999999995d, new GammaParticle(34030.0, 0.03643) }, { 0.00079d, new GammaParticle(34414.0, 0.03603) } } },
            { 0.076d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon140() }, { 1.0d, new BetaParticle(-1, 4690250.0) }, { 0.006999999999999999d, new GammaParticle(258600.0, 0.00479) }, { 0.013000000000000001d, new GammaParticle(355000.0, 0.00349) }, { 0.98d, new GammaParticle(376657.0, 0.00329) }, { 0.68d, new GammaParticle(457630.0, 0.00271) }, { 0.09300000000000001d, new GammaParticle(582400.0, 0.00213) }, { 0.017d, new GammaParticle(678700.0, 0.00183) }, { 0.188d, new GammaParticle(937400.0, 0.00132) }, { 0.044000000000000004d, new GammaParticle(1136700.0, 0.00109) }, { 0.00252d, new GammaParticle(4540.0, 0.27309) }, { 0.0062d, new GammaParticle(29458.0, 0.04209) }, { 0.0115d, new GammaParticle(29778.0, 0.04164) }, { 0.00333d, new GammaParticle(33726.0, 0.03676) }, { 0.0041199999999999995d, new GammaParticle(34030.0, 0.03643) }, { 0.00079d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    