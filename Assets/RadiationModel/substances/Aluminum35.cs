using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum35 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum35";
        public override double halfLife { get; } = 0.0383d;
        public override double atomicWeight { get; } = 34.99976d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon35() }, { 1.0d, new BetaParticle(-1, 7083000.0) }, { 0.45d, new GammaParticle(64100.0, 0.01934) }, { 0.44865d, new GammaParticle(910110.0, 0.00136) }, { 0.053099999999999994d, new GammaParticle(973780.0, 0.00127) }, { 0.0144d, new GammaParticle(1130400.0, 0.0011) }, { 0.023849999999999996d, new GammaParticle(1194200.0, 0.00104) }, { 0.0675d, new GammaParticle(2168200.0, 0.00057) }, { 0.0108d, new GammaParticle(5629000.0, 0.00022) }, { 1.66468212377775e-05d, new GammaParticle(118.0, 10.50714) }, { 0.0005013752055949067d, new GammaParticle(1740.0, 0.71255) }, { 0.0002525426910581545d, new GammaParticle(1740.0, 0.71255) }, { 2.1863619002938775e-05d, new GammaParticle(1836.0, 0.6753) }, { 2.1863619002938775e-05d, new GammaParticle(1836.0, 0.6753) } } },
            { 0.38d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon35() }, { 1.0d, new BetaParticle(-1, 7083000.0) }, { 0.45d, new GammaParticle(64100.0, 0.01934) }, { 0.44865d, new GammaParticle(910110.0, 0.00136) }, { 0.053099999999999994d, new GammaParticle(973780.0, 0.00127) }, { 0.0144d, new GammaParticle(1130400.0, 0.0011) }, { 0.023849999999999996d, new GammaParticle(1194200.0, 0.00104) }, { 0.0675d, new GammaParticle(2168200.0, 0.00057) }, { 0.0108d, new GammaParticle(5629000.0, 0.00022) }, { 1.66468212377775e-05d, new GammaParticle(118.0, 10.50714) }, { 0.0005013752055949067d, new GammaParticle(1740.0, 0.71255) }, { 0.0002525426910581545d, new GammaParticle(1740.0, 0.71255) }, { 2.1863619002938775e-05d, new GammaParticle(1836.0, 0.6753) }, { 2.1863619002938775e-05d, new GammaParticle(1836.0, 0.6753) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon33() }, { 1.0d, new BetaParticle(-1, 941639253.472) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    