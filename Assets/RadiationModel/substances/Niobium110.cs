using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium110 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium110";
        public override double halfLife { get; } = 0.082d;
        public override double atomicWeight { get; } = 109.94384d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum110() }, { 1.0d, new BetaParticle(-1, 6113000.0) }, { 0.0738d, new GammaParticle(206600.0, 0.006) }, { 0.41d, new GammaParticle(213800.0, 0.0058) }, { 0.0861d, new GammaParticle(280600.0, 0.00442) }, { 0.2296d, new GammaParticle(385900.0, 0.00321) }, { 0.0861d, new GammaParticle(421300.0, 0.00294) }, { 0.0902d, new GammaParticle(462900.0, 0.00268) }, { 0.12300000000000001d, new GammaParticle(487000.0, 0.00255) }, { 0.1558d, new GammaParticle(494100.0, 0.00251) }, { 0.1189d, new GammaParticle(532000.0, 0.00233) }, { 0.0492d, new GammaParticle(563700.0, 0.0022) }, { 0.0015857083156610998d, new GammaParticle(2440.0, 0.50813) }, { 0.007879272789446008d, new GammaParticle(17374.0, 0.07136) }, { 0.01501671962920909d, new GammaParticle(17479.0, 0.07093) }, { 0.003940332837387264d, new GammaParticle(19681.0, 0.063) }, { 0.004547144094344903d, new GammaParticle(19794.0, 0.06264) }, { 0.0006068112569576386d, new GammaParticle(19963.0, 0.06211) } } },
            { 0.4d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum110() }, { 1.0d, new BetaParticle(-1, 6113000.0) }, { 0.0738d, new GammaParticle(206600.0, 0.006) }, { 0.41d, new GammaParticle(213800.0, 0.0058) }, { 0.0861d, new GammaParticle(280600.0, 0.00442) }, { 0.2296d, new GammaParticle(385900.0, 0.00321) }, { 0.0861d, new GammaParticle(421300.0, 0.00294) }, { 0.0902d, new GammaParticle(462900.0, 0.00268) }, { 0.12300000000000001d, new GammaParticle(487000.0, 0.00255) }, { 0.1558d, new GammaParticle(494100.0, 0.00251) }, { 0.1189d, new GammaParticle(532000.0, 0.00233) }, { 0.0492d, new GammaParticle(563700.0, 0.0022) }, { 0.0015857083156610998d, new GammaParticle(2440.0, 0.50813) }, { 0.007879272789446008d, new GammaParticle(17374.0, 0.07136) }, { 0.01501671962920909d, new GammaParticle(17479.0, 0.07093) }, { 0.003940332837387264d, new GammaParticle(19681.0, 0.063) }, { 0.004547144094344903d, new GammaParticle(19794.0, 0.06264) }, { 0.0006068112569576386d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    