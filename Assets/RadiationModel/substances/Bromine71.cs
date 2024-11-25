using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine71 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine71";
        public override double halfLife { get; } = 21.4d;
        public override double atomicWeight { get; } = 70.93934d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic71() }, { 1.0d, new BetaParticle(1, 5695500.0) }, { 0.014041999999999999d, new GammaParticle(48780.0, 0.02542) }, { 0.052864d, new GammaParticle(122720.0, 0.0101) }, { 0.06360199999999999d, new GammaParticle(171600.0, 0.00723) }, { 0.066906d, new GammaParticle(233700.0, 0.00531) }, { 0.08259999999999999d, new GammaParticle(260500.0, 0.00476) }, { 0.025606d, new GammaParticle(282400.0, 0.00439) }, { 0.017346d, new GammaParticle(387400.0, 0.0032) }, { 0.021476000000000002d, new GammaParticle(474600.0, 0.00261) }, { 0.012390000000000002d, new GammaParticle(647600.0, 0.00191) }, { 0.041299999999999996d, new GammaParticle(756900.0, 0.00164) }, { 0.046256000000000005d, new GammaParticle(796400.0, 0.00156) }, { 1.2d, new GammaParticle(511000.0, 0.00243) }, { 0.0034763160607d, new GammaParticle(1426.0, 0.86945) }, { 0.024863920956629388d, new GammaParticle(11183.0, 0.11087) }, { 0.048204577271480004d, new GammaParticle(11223.0, 0.11047) }, { 0.011248757632920459d, new GammaParticle(12546.0, 0.09882) }, { 0.011880937811890589d, new GammaParticle(12571.0, 0.09863) }, { 0.0006321801789701298d, new GammaParticle(12652.0, 0.098) } } },

        };
    }
}
    