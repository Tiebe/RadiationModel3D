using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium77 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium77";
        public override double halfLife { get; } = 9.0d;
        public override double atomicWeight { get; } = 76.93795d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton77() }, { 1.0d, new BetaParticle(1, 6183250.0) }, { 0.06788999999999999d, new GammaParticle(144820.0, 0.00856) }, { 0.86118d, new GammaParticle(146940.0, 0.00844) }, { 0.09207000000000001d, new GammaParticle(160100.0, 0.00774) }, { 0.016739999999999998d, new GammaParticle(162110.0, 0.00765) }, { 0.01302d, new GammaParticle(641200.0, 0.00193) }, { 0.01209d, new GammaParticle(942000.0, 0.00132) }, { 0.02418d, new GammaParticle(1234200.0, 0.001) }, { 2.026d, new GammaParticle(511000.0, 0.00243) }, { 0.0014000000000000002d, new GammaParticle(1767.0, 0.70166) }, { 0.009300000000000001d, new GammaParticle(13336.0, 0.09297) }, { 0.0179d, new GammaParticle(13396.0, 0.09255) }, { 0.00437d, new GammaParticle(15021.0, 0.08254) }, { 0.00488d, new GammaParticle(15070.0, 0.08227) }, { 0.0005099999999999999d, new GammaParticle(15187.0, 0.08164) } } },
            { 0.0008d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton76() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    