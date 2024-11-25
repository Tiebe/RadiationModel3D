using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon32 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon32";
        public override double halfLife { get; } = 0.098d;
        public override double atomicWeight { get; } = 31.99764d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur32() }, { 1.0d, new BetaParticle(1, 11907568.55) }, { 0.12d, new GammaParticle(89900.0, 0.01379) }, { 0.32799999999999996d, new GammaParticle(461100.0, 0.00269) }, { 0.32799999999999996d, new GammaParticle(707400.0, 0.00175) }, { 0.12d, new GammaParticle(1078700.0, 0.00115) }, { 0.121d, new GammaParticle(1168500.0, 0.00106) }, { 0.0024d, new GammaParticle(2836000.0, 0.00044) }, { 0.0158d, new GammaParticle(3877500.0, 0.00032) }, { 0.00098d, new GammaParticle(5046000.0, 0.00025) }, { 2.0498d, new GammaParticle(511000.0, 0.00243) }, { 2.9e-06d, new GammaParticle(223.0, 5.55983) }, { 4.13e-05d, new GammaParticle(2621.0, 0.47304) }, { 8.2e-05d, new GammaParticle(2623.0, 0.47268) }, { 1.06e-05d, new GammaParticle(2816.0, 0.44028) }, { 1.06e-05d, new GammaParticle(2816.0, 0.44028) } } },
            { 0.3558d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur31() }, { 1.0d, new ProtonParticle() }, { 0.019d, new GammaParticle(1248400.0, 0.00099) }, { 7.067931087e-10d, new GammaParticle(185.0, 6.70185) }, { 1.0250885055102853e-08d, new GammaParticle(2306.0, 0.53766) }, { 2.0286730764106183e-08d, new GammaParticle(2308.0, 0.53719) }, { 1.8933321807909603e-09d, new GammaParticle(2466.0, 0.50277) }, { 1.8933321807909603e-09d, new GammaParticle(2466.0, 0.50277) } } },

        };
    }
}
    