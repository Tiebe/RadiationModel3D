using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium46 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium46";
        public override double halfLife { get; } = 105.0d;
        public override double atomicWeight { get; } = 45.96198d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium46() }, { 1.0d, new BetaParticle(-1, 3862850.0) }, { 0.9d, new GammaParticle(1347000.0, 0.00092) }, { 0.027000000000000003d, new GammaParticle(1439000.0, 0.00086) }, { 0.045d, new GammaParticle(1670000.0, 0.00074) }, { 0.081d, new GammaParticle(1780000.0, 0.0007) }, { 0.081d, new GammaParticle(2274000.0, 0.00055) }, { 0.09d, new GammaParticle(3015000.0, 0.00041) }, { 0.27899999999999997d, new GammaParticle(3700000.0, 0.00034) } } },

        };
    }
}
    