using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium90m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium90m";
        public override double halfLife { get; } = 8.7d;
        public override double atomicWeight { get; } = 89.92423d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium90() }, { 1.0d, new BetaParticle(1, 6040650.0) }, { 0.78d, new GammaParticle(948100.0, 0.00131) }, { 2.0d, new GammaParticle(511000.0, 0.00243) }, { 0.00025297180342799997d, new GammaParticle(2440.0, 0.50813) }, { 0.001273223981589067d, new GammaParticle(17374.0, 0.07136) }, { 0.0024265751507319745d, new GammaParticle(17479.0, 0.07093) }, { 0.0006367245300510907d, new GammaParticle(19681.0, 0.063) }, { 0.0007347801076789587d, new GammaParticle(19794.0, 0.06264) }, { 9.805557762786796e-05d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    