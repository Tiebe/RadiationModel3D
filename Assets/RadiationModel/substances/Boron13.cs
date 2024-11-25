using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron13 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron13";
        public override double halfLife { get; } = 0.01733d;
        public override double atomicWeight { get; } = 13.01778d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon13() }, { 1.0d, new BetaParticle(-1, 6718445.35) }, { 8.999999999999999e-05d, new GammaParticle(169300.0, 0.00732) }, { 0.00057d, new GammaParticle(595013.0, 0.00208) }, { 0.003d, new GammaParticle(764316.0, 0.00162) }, { 0.006999999999999999d, new GammaParticle(3089049.0, 0.0004) }, { 0.076d, new GammaParticle(3683921.0, 0.00034) }, { 0.005d, new GammaParticle(3853170.0, 0.00032) }, { 0.00094d, new GammaParticle(7545000.0, 0.00016) }, { 0.0016d, new GammaParticle(8857000.0, 0.00014) }, { 0.00021999999999999998d, new GammaParticle(9893000.0, 0.00013) } } },
            { 0.0028599999999999997d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon13() }, { 1.0d, new BetaParticle(-1, 6718445.35) }, { 8.999999999999999e-05d, new GammaParticle(169300.0, 0.00732) }, { 0.00057d, new GammaParticle(595013.0, 0.00208) }, { 0.003d, new GammaParticle(764316.0, 0.00162) }, { 0.006999999999999999d, new GammaParticle(3089049.0, 0.0004) }, { 0.076d, new GammaParticle(3683921.0, 0.00034) }, { 0.005d, new GammaParticle(3853170.0, 0.00032) }, { 0.00094d, new GammaParticle(7545000.0, 0.00016) }, { 0.0016d, new GammaParticle(8857000.0, 0.00014) }, { 0.00021999999999999998d, new GammaParticle(9893000.0, 0.00013) } } },

        };
    }
}
    