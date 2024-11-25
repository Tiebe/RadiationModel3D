using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur31 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur31";
        public override double halfLife { get; } = 2.5534d;
        public override double atomicWeight { get; } = 30.97956d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon31() }, { 1.0d, new BetaParticle(1, 1953255.0) }, { 0.011000000000000001d, new GammaParticle(1266100.0, 0.00098) }, { 1.88e-05d, new GammaParticle(1868100.0, 0.00066) }, { 7.1e-06d, new GammaParticle(2233600.0, 0.00056) }, { 4.9e-05d, new GammaParticle(2239900.0, 0.00055) }, { 8.2e-06d, new GammaParticle(2358600.0, 0.00053) }, { 0.00031800000000000003d, new GammaParticle(3134100.0, 0.0004) }, { 6.2e-06d, new GammaParticle(3326200.0, 0.00037) }, { 7.3e-05d, new GammaParticle(3505900.0, 0.00035) }, { 2e-06d, new GammaParticle(4260100.0, 0.00029) }, { 5.6e-07d, new GammaParticle(4592100.0, 0.00027) }, { 1.9986560320000002d, new GammaParticle(511000.0, 0.00243) }, { 9.2e-07d, new GammaParticle(149.0, 8.32109) }, { 1.3500000000000001e-05d, new GammaParticle(2013.0, 0.61592) }, { 2.6700000000000002e-05d, new GammaParticle(2014.0, 0.61561) }, { 1.73e-06d, new GammaParticle(2138.0, 0.57991) }, { 1.73e-06d, new GammaParticle(2138.0, 0.57991) } } },

        };
    }
}
    