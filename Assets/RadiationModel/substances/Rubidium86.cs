using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium86";
        public override double halfLife { get; } = 1610668.8d;
        public override double atomicWeight { get; } = 85.91117d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.999948d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium86() }, { 1.0d, new BetaParticle(-1, 888050.0) }, { 0.0864d, new GammaParticle(1077000.0, 0.00115) } } },
            { 5.2e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton86() }, { 1.2354366206e-06d, new GammaParticle(1648.0, 0.75233) }, { 8.51617726200622e-06d, new GammaParticle(12596.0, 0.09843) }, { 1.6421475630555765e-05d, new GammaParticle(12649.0, 0.09802) }, { 3.935020264751106e-06d, new GammaParticle(14169.0, 0.0875) }, { 4.331670307438017e-06d, new GammaParticle(14209.0, 0.08726) }, { 3.9665004268691147e-07d, new GammaParticle(14313.0, 0.08662) } } },

        };
    }
}
    