using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton85 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton85";
        public override double halfLife { get; } = 338889828.04114d;
        public override double atomicWeight { get; } = 84.91253d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium85() }, { 1.0d, new BetaParticle(-1, 343520.5) }, { 4.34e-09d, new GammaParticle(129810.0, 0.00955) }, { 2.17e-08d, new GammaParticle(151180.0, 0.0082) }, { 2.17e-08d, new GammaParticle(362810.0, 0.00342) }, { 0.00434d, new GammaParticle(513997.0, 0.00241) }, { 8.000000000000001e-07d, new GammaParticle(1767.0, 0.70166) }, { 5.330000000000001e-06d, new GammaParticle(13336.0, 0.09297) }, { 1.0300000000000001e-05d, new GammaParticle(13396.0, 0.09255) }, { 2.5e-06d, new GammaParticle(15021.0, 0.08254) }, { 2.79e-06d, new GammaParticle(15070.0, 0.08227) }, { 2.9e-07d, new GammaParticle(15187.0, 0.08164) } } },

        };
    }
}
    