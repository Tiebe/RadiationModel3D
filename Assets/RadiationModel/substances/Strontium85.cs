using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium85";
        public override double halfLife { get; } = 5602953.6d;
        public override double atomicWeight { get; } = 84.91293d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium85() }, { 4.8e-06d, new GammaParticle(129800.0, 0.00955) }, { 1.152e-05d, new GammaParticle(151180.0, 0.0082) }, { 3.84e-07d, new GammaParticle(233000.0, 0.00532) }, { 4.8e-06d, new GammaParticle(354060.0, 0.0035) }, { 1.3728e-05d, new GammaParticle(362820.0, 0.00342) }, { 0.9571200000000001d, new GammaParticle(514004.8, 0.00241) }, { 3.072e-06d, new GammaParticle(716870.0, 0.00173) }, { 0.00012d, new GammaParticle(868060.0, 0.00143) }, { 2.88e-07d, new GammaParticle(951000.0, 0.0013) }, { 0.0259d, new GammaParticle(1767.0, 0.70166) }, { 0.172d, new GammaParticle(13336.0, 0.09297) }, { 0.33d, new GammaParticle(13396.0, 0.09255) }, { 0.08d, new GammaParticle(15021.0, 0.08254) }, { 0.09d, new GammaParticle(15070.0, 0.08227) }, { 0.009300000000000001d, new GammaParticle(15187.0, 0.08164) } } },

        };
    }
}
    