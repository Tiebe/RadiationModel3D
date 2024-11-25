using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper73 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper73";
        public override double halfLife { get; } = 4.2d;
        public override double atomicWeight { get; } = 72.93667d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc73() }, { 1.0d, new BetaParticle(-1, 3303000.0) }, { 0.0564d, new GammaParticle(307200.0, 0.00404) }, { 0.47d, new GammaParticle(449600.0, 0.00276) }, { 0.0799d, new GammaParticle(502200.0, 0.00247) }, { 0.0329d, new GammaParticle(674400.0, 0.00184) }, { 0.009399999999999999d, new GammaParticle(1559300.0, 0.0008) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    