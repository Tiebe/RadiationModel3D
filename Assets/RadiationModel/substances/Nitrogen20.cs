using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen20 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen20";
        public override double halfLife { get; } = 0.1344d;
        public override double atomicWeight { get; } = 20.02337d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen20() }, { 1.0d, new BetaParticle(-1, 8986900.0) }, { 0.516d, new GammaParticle(1673520.0, 0.00074) }, { 0.028999999999999998d, new GammaParticle(1812100.0, 0.00068) }, { 0.065d, new GammaParticle(1898200.0, 0.00065) }, { 0.071d, new GammaParticle(2397000.0, 0.00052) }, { 0.013999999999999999d, new GammaParticle(2779500.0, 0.00045) }, { 0.021d, new GammaParticle(2982000.0, 0.00042) }, { 0.022000000000000002d, new GammaParticle(4072000.0, 0.0003) }, { 0.022000000000000002d, new GammaParticle(4882000.0, 0.00025) } } },
            { 0.429d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen20() }, { 1.0d, new BetaParticle(-1, 8986900.0) }, { 0.516d, new GammaParticle(1673520.0, 0.00074) }, { 0.028999999999999998d, new GammaParticle(1812100.0, 0.00068) }, { 0.065d, new GammaParticle(1898200.0, 0.00065) }, { 0.071d, new GammaParticle(2397000.0, 0.00052) }, { 0.013999999999999999d, new GammaParticle(2779500.0, 0.00045) }, { 0.021d, new GammaParticle(2982000.0, 0.00042) }, { 0.022000000000000002d, new GammaParticle(4072000.0, 0.0003) }, { 0.022000000000000002d, new GammaParticle(4882000.0, 0.00025) } } },

        };
    }
}
    