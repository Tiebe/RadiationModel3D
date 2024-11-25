using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon135m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon135m";
        public override double halfLife { get; } = 917.4d;
        public override double atomicWeight { get; } = 134.9078d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9940000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon135() }, { 0.8059999999999999d, new GammaParticle(526561.0, 0.00235) }, { 0.0162540114548d, new GammaParticle(4540.0, 0.27309) }, { 0.038732581660973694d, new GammaParticle(29458.0, 0.04209) }, { 0.07175357847531251d, new GammaParticle(29778.0, 0.04164) }, { 0.02080107561789142d, new GammaParticle(33726.0, 0.03676) }, { 0.0257101294637138d, new GammaParticle(34030.0, 0.03643) }, { 0.004909053845822376d, new GammaParticle(34414.0, 0.03603) } } },
            { 0.006d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium135() }, { 1.0d, new BetaParticle(-1, 848000.0) }, { 4e-05d, new GammaParticle(786900.0, 0.00158) }, { 2.9999999999999997e-06d, new GammaParticle(1133000.0, 0.00109) }, { 4.0000000000000003e-07d, new GammaParticle(1192200.0, 0.00104) }, { 2e-06d, new GammaParticle(1358000.0, 0.00091) } } },

        };
    }
}
    