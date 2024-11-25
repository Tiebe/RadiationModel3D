using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper57 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper57";
        public override double halfLife { get; } = 0.1963d;
        public override double atomicWeight { get; } = 56.94921d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt57() }, { 1.0d, new BetaParticle(1, 6018350.0) }, { 0.009399999999999999d, new GammaParticle(768500.0, 0.00161) }, { 0.086d, new GammaParticle(1112600.0, 0.00111) }, { 0.0017000000000000001d, new GammaParticle(2443100.0, 0.00051) }, { 0.0004d, new GammaParticle(2461600.0, 0.0005) }, { 0.0003d, new GammaParticle(2577500.0, 0.00048) }, { 0.0034999999999999996d, new GammaParticle(3007000.0, 0.00041) }, { 0.0002d, new GammaParticle(3230100.0, 0.00038) }, { 1.999d, new GammaParticle(511000.0, 0.00243) }, { 1.3899999999999999e-05d, new GammaParticle(874.0, 1.41858) }, { 0.0001386d, new GammaParticle(7461.0, 0.16618) }, { 0.000271d, new GammaParticle(7478.0, 0.1658) }, { 5.64e-05d, new GammaParticle(8296.0, 0.14945) }, { 5.64e-05d, new GammaParticle(8296.0, 0.14945) } } },

        };
    }
}
    