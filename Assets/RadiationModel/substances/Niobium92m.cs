using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium92m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium92m";
        public override double halfLife { get; } = 876960.0d;
        public override double atomicWeight { get; } = 91.90733d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium92() }, { 1.0d, new BetaParticle(1, -750900.0) }, { 3.27195e-05d, new GammaParticle(449000.0, 0.00276) }, { 4.46175e-05d, new GammaParticle(561000.0, 0.00221) }, { 0.017847d, new GammaParticle(912600.0, 0.00136) }, { 0.9915d, new GammaParticle(934440.0, 0.00133) }, { 5.1558000000000003e-05d, new GammaParticle(1132170.0, 0.0011) }, { 0.008526899999999999d, new GammaParticle(1847500.0, 0.00067) }, { 0.0014199999999999998d, new GammaParticle(511000.0, 0.00243) }, { 0.0327d, new GammaParticle(2161.0, 0.57374) }, { 0.1841d, new GammaParticle(15691.0, 0.07902) }, { 0.35229999999999995d, new GammaParticle(15775.0, 0.0786) }, { 0.0898d, new GammaParticle(17736.0, 0.06991) }, { 0.10289999999999999d, new GammaParticle(17824.0, 0.06956) }, { 0.0131d, new GammaParticle(17968.0, 0.069) } } },

        };
    }
}
    