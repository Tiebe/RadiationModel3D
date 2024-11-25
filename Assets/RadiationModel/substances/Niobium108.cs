using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium108";
        public override double halfLife { get; } = 0.198d;
        public override double atomicWeight { get; } = 107.93608d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum108() }, { 1.0d, new BetaParticle(-1, 5602000.0) }, { 0.78d, new GammaParticle(192700.0, 0.00643) }, { 0.078d, new GammaParticle(196900.0, 0.0063) }, { 0.039d, new GammaParticle(219400.0, 0.00565) }, { 0.12480000000000001d, new GammaParticle(370900.0, 0.00334) }, { 0.195d, new GammaParticle(393200.0, 0.00315) }, { 0.1326d, new GammaParticle(586000.0, 0.00212) }, { 0.41340000000000005d, new GammaParticle(590100.0, 0.0021) }, { 0.00349614676944d, new GammaParticle(2440.0, 0.50813) }, { 0.017266123266239067d, new GammaParticle(17374.0, 0.07136) }, { 0.03290665764482383d, new GammaParticle(17479.0, 0.07093) }, { 0.008634587772042542d, new GammaParticle(19681.0, 0.063) }, { 0.009964314288937091d, new GammaParticle(19794.0, 0.06264) }, { 0.0013297265168945513d, new GammaParticle(19963.0, 0.06211) } } },
            { 0.063d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum108() }, { 1.0d, new BetaParticle(-1, 5602000.0) }, { 0.78d, new GammaParticle(192700.0, 0.00643) }, { 0.078d, new GammaParticle(196900.0, 0.0063) }, { 0.039d, new GammaParticle(219400.0, 0.00565) }, { 0.12480000000000001d, new GammaParticle(370900.0, 0.00334) }, { 0.195d, new GammaParticle(393200.0, 0.00315) }, { 0.1326d, new GammaParticle(586000.0, 0.00212) }, { 0.41340000000000005d, new GammaParticle(590100.0, 0.0021) }, { 0.00349614676944d, new GammaParticle(2440.0, 0.50813) }, { 0.017266123266239067d, new GammaParticle(17374.0, 0.07136) }, { 0.03290665764482383d, new GammaParticle(17479.0, 0.07093) }, { 0.008634587772042542d, new GammaParticle(19681.0, 0.063) }, { 0.009964314288937091d, new GammaParticle(19794.0, 0.06264) }, { 0.0013297265168945513d, new GammaParticle(19963.0, 0.06211) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    