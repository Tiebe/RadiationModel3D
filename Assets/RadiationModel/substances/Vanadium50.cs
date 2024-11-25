using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium50 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium50";
        public override double halfLife { get; } = 8.36258538326688e+24d;
        public override double atomicWeight { get; } = 49.94716d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.993d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium50() }, { 1.0d, new BetaParticle(1, -2343070.0) }, { 0.993d, new GammaParticle(1553770.0, 0.0008) }, { 0.0047475821603556725d, new GammaParticle(477.0, 2.59925) }, { 0.05955021466364651d, new GammaParticle(4505.0, 0.27521) }, { 0.11731720776920117d, new GammaParticle(4511.0, 0.27485) }, { 0.023434933472352322d, new GammaParticle(4947.0, 0.25063) }, { 0.023434933472352322d, new GammaParticle(4947.0, 0.25063) } } },
            { 0.006999999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium50() }, { 1.0d, new BetaParticle(-1, 519060.0) } } },

        };
    }
}
    