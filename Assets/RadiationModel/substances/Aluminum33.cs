using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum33 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum33";
        public override double halfLife { get; } = 0.0417d;
        public override double atomicWeight { get; } = 32.99088d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon33() }, { 1.0d, new BetaParticle(-1, 6008650.0) }, { 0.01d, new GammaParticle(1010200.0, 0.00123) }, { 0.013000000000000001d, new GammaParticle(4341000.0, 0.00029) } } },
            { 0.085d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon33() }, { 1.0d, new BetaParticle(-1, 6008650.0) }, { 0.01d, new GammaParticle(1010200.0, 0.00123) }, { 0.013000000000000001d, new GammaParticle(4341000.0, 0.00029) } } },

        };
    }
}
    