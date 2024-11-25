using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium140";
        public override double halfLife { get; } = 2.29d;
        public override double atomicWeight { get; } = 139.94581d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium140() }, { 1.0d, new BetaParticle(1, 8255000.0) }, { 0.84d, new GammaParticle(328700.0, 0.00377) }, { 0.13d, new GammaParticle(355000.0, 0.00349) }, { 0.19d, new GammaParticle(385000.0, 0.00322) }, { 0.48d, new GammaParticle(507800.0, 0.00244) }, { 0.15d, new GammaParticle(568100.0, 0.00218) }, { 0.2d, new GammaParticle(600200.0, 0.00207) }, { 0.15d, new GammaParticle(625400.0, 0.00198) }, { 0.44d, new GammaParticle(628000.0, 0.00197) }, { 0.18d, new GammaParticle(675900.0, 0.00183) }, { 0.12d, new GammaParticle(713800.0, 0.00174) }, { 0.13d, new GammaParticle(718000.0, 0.00173) }, { 0.08d, new GammaParticle(740000.0, 0.00168) }, { 1.52d, new GammaParticle(511000.0, 0.00243) }, { 0.014499999999999999d, new GammaParticle(6858.0, 0.18079) }, { 0.021099999999999997d, new GammaParticle(42308.0, 0.02931) }, { 0.038d, new GammaParticle(42996.0, 0.02884) }, { 0.012d, new GammaParticle(48802.0, 0.02541) }, { 0.0152d, new GammaParticle(49326.0, 0.02514) }, { 0.0032d, new GammaParticle(49957.0, 0.02482) } } },
            { 0.0026d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium139() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    