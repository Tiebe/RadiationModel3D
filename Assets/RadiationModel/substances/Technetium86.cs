using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium86";
        public override double halfLife { get; } = 0.055d;
        public override double atomicWeight { get; } = 85.94464d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium86() }, { 1.0d, new BetaParticle(1, 8782000.0) }, { 1.99646d, new GammaParticle(511000.0, 0.00243) }, { 6.7424046e-05d, new GammaParticle(2440.0, 0.50813) }, { 0.000339131769031908d, new GammaParticle(17374.0, 0.07136) }, { 0.0006463346084084391d, new GammaParticle(17479.0, 0.07093) }, { 0.00016959586010368538d, new GammaParticle(19681.0, 0.063) }, { 0.00019571362255965292d, new GammaParticle(19794.0, 0.06264) }, { 2.6117762455967548e-05d, new GammaParticle(19963.0, 0.06211) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    