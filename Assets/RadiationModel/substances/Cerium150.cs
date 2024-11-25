using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium150";
        public override double halfLife { get; } = 4.0d;
        public override double atomicWeight { get; } = 149.93038d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium150() }, { 1.0d, new BetaParticle(-1, 1727000.0) }, { 0.037185d, new GammaParticle(100300.0, 0.01236) }, { 0.5025d, new GammaParticle(109900.0, 0.01128) }, { 0.0095475d, new GammaParticle(180400.0, 0.00687) }, { 0.013065d, new GammaParticle(230000.0, 0.00539) }, { 0.0185925d, new GammaParticle(278800.0, 0.00445) }, { 0.0035175000000000002d, new GammaParticle(378400.0, 0.00328) }, { 0.053919657d, new GammaParticle(5637.0, 0.21995) }, { 0.10426663128435493d, new GammaParticle(35551.0, 0.03488) }, { 0.1904065582256299d, new GammaParticle(36027.0, 0.03441) }, { 0.057925804530266925d, new GammaParticle(40857.0, 0.03035) }, { 0.07275481049001525d, new GammaParticle(41266.0, 0.03005) }, { 0.014829005959748334d, new GammaParticle(41766.0, 0.02969) } } },

        };
    }
}
    