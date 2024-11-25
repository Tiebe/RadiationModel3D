using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon18 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon18";
        public override double halfLife { get; } = 0.092d;
        public override double atomicWeight { get; } = 18.02675d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen18() }, { 1.0d, new BetaParticle(-1, 5903500.0) }, { 0.287d, new GammaParticle(114700.0, 0.01081) }, { 0.076d, new GammaParticle(472700.0, 0.00262) }, { 0.14d, new GammaParticle(879700.0, 0.00141) }, { 0.054000000000000006d, new GammaParticle(1147800.0, 0.00108) }, { 0.08d, new GammaParticle(1619900.0, 0.00077) }, { 0.08d, new GammaParticle(1734800.0, 0.00071) }, { 0.022000000000000002d, new GammaParticle(2025300.0, 0.00061) }, { 0.131d, new GammaParticle(2499300.0, 0.0005) }, { 0.319d, new GammaParticle(2614200.0, 0.00047) } } },
            { 0.315d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen18() }, { 1.0d, new BetaParticle(-1, 5903500.0) }, { 0.287d, new GammaParticle(114700.0, 0.01081) }, { 0.076d, new GammaParticle(472700.0, 0.00262) }, { 0.14d, new GammaParticle(879700.0, 0.00141) }, { 0.054000000000000006d, new GammaParticle(1147800.0, 0.00108) }, { 0.08d, new GammaParticle(1619900.0, 0.00077) }, { 0.08d, new GammaParticle(1734800.0, 0.00071) }, { 0.022000000000000002d, new GammaParticle(2025300.0, 0.00061) }, { 0.131d, new GammaParticle(2499300.0, 0.0005) }, { 0.319d, new GammaParticle(2614200.0, 0.00047) } } },

        };
    }
}
    