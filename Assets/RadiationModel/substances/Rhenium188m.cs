using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium188m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium188m";
        public override double halfLife { get; } = 1115.4d;
        public override double atomicWeight { get; } = 187.9583d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium188() }, { 3.8e-13d, new GammaParticle(2636.0, 0.47035) }, { 1.9800000000000002e-08d, new GammaParticle(15930.0, 0.07783) }, { 0.223d, new GammaParticle(63583.0, 0.0195) }, { 0.052000000000000005d, new GammaParticle(92464.0, 0.01341) }, { 0.115d, new GammaParticle(105853.0, 0.01171) }, { 0.0038d, new GammaParticle(156050.0, 0.00795) }, { 0.0051d, new GammaParticle(169441.0, 0.00732) }, { 0.4501169643395d, new GammaParticle(10063.0, 0.12321) }, { 0.16808066032703414d, new GammaParticle(59718.0, 0.02076) }, { 0.2907969901851802d, new GammaParticle(61141.0, 0.02028) }, { 0.09666255911337954d, new GammaParticle(69395.0, 0.01787) }, { 0.12343808798778566d, new GammaParticle(70206.0, 0.01766) }, { 0.026775528874406134d, new GammaParticle(71195.0, 0.01741) } } },

        };
    }
}
    