using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon133 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon133";
        public override double halfLife { get; } = 453384.0d;
        public override double atomicWeight { get; } = 132.90591d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium133() }, { 1.0d, new BetaParticle(-1, 213671.5) }, { 0.0044d, new GammaParticle(79614.2, 0.01557) }, { 0.369d, new GammaParticle(80997.9, 0.01531) }, { 0.001066d, new GammaParticle(160612.0, 0.00772) }, { 1.37e-06d, new GammaParticle(223236.8, 0.00555) }, { 5.4999999999999995e-05d, new GammaParticle(302850.8, 0.00409) }, { 2.7000000000000002e-05d, new GammaParticle(383848.5, 0.00323) }, { 0.05817938627574736d, new GammaParticle(4749.0, 0.26107) }, { 0.1358900495116634d, new GammaParticle(30625.0, 0.04048) }, { 0.2510438749522693d, new GammaParticle(30973.0, 0.04003) }, { 0.073343263174112d, new GammaParticle(35089.0, 0.03533) }, { 0.09123901938859533d, new GammaParticle(35414.0, 0.03501) }, { 0.017895756214483326d, new GammaParticle(35818.0, 0.03462) } } },

        };
    }
}
    