using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium131n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium131n";
        public override double halfLife { get; } = 0.32d;
        public override double atomicWeight { get; } = 130.93099d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin131() }, { 1.0d, new BetaParticle(-1, 6492500.0) }, { 0.259d, new GammaParticle(158570.0, 0.00782) }, { 0.013000000000000001d, new GammaParticle(171100.0, 0.00725) }, { 0.38d, new GammaParticle(173185.0, 0.00716) }, { 0.019d, new GammaParticle(259200.0, 0.00478) }, { 0.081d, new GammaParticle(270340.0, 0.00459) }, { 0.36d, new GammaParticle(284670.0, 0.00436) }, { 0.057d, new GammaParticle(344400.0, 0.0036) }, { 0.054000000000000006d, new GammaParticle(2078800.0, 0.0006) }, { 0.21899999999999997d, new GammaParticle(2095900.0, 0.00059) }, { 0.145d, new GammaParticle(2380200.0, 0.00052) }, { 0.102d, new GammaParticle(4102300.0, 0.0003) }, { 0.87d, new GammaParticle(4273200.0, 0.00029) }, { 0.032d, new GammaParticle(4446000.0, 0.00028) }, { 0.008801366712d, new GammaParticle(3753.0, 0.33036) }, { 0.02691134078012007d, new GammaParticle(25044.0, 0.04951) }, { 0.050367472918061144d, new GammaParticle(25271.0, 0.04906) }, { 0.01424202698564643d, new GammaParticle(28579.0, 0.04338) }, { 0.017047706301818778d, new GammaParticle(28810.0, 0.04304) }, { 0.0028056793161723463d, new GammaParticle(29107.0, 0.0426) } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium131() } } },
            { 0.0003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin131() }, { 1.0d, new BetaParticle(-1, 6492500.0) }, { 0.259d, new GammaParticle(158570.0, 0.00782) }, { 0.013000000000000001d, new GammaParticle(171100.0, 0.00725) }, { 0.38d, new GammaParticle(173185.0, 0.00716) }, { 0.019d, new GammaParticle(259200.0, 0.00478) }, { 0.081d, new GammaParticle(270340.0, 0.00459) }, { 0.36d, new GammaParticle(284670.0, 0.00436) }, { 0.057d, new GammaParticle(344400.0, 0.0036) }, { 0.054000000000000006d, new GammaParticle(2078800.0, 0.0006) }, { 0.21899999999999997d, new GammaParticle(2095900.0, 0.00059) }, { 0.145d, new GammaParticle(2380200.0, 0.00052) }, { 0.102d, new GammaParticle(4102300.0, 0.0003) }, { 0.87d, new GammaParticle(4273200.0, 0.00029) }, { 0.032d, new GammaParticle(4446000.0, 0.00028) }, { 0.008801366712d, new GammaParticle(3753.0, 0.33036) }, { 0.02691134078012007d, new GammaParticle(25044.0, 0.04951) }, { 0.050367472918061144d, new GammaParticle(25271.0, 0.04906) }, { 0.01424202698564643d, new GammaParticle(28579.0, 0.04338) }, { 0.017047706301818778d, new GammaParticle(28810.0, 0.04304) }, { 0.0028056793161723463d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    