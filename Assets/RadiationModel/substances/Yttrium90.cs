using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium90";
        public override double halfLife { get; } = 230580.0d;
        public override double atomicWeight { get; } = 89.90714d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium90() }, { 1.0d, new BetaParticle(-1, 1137825.0) }, { 1.4e-08d, new GammaParticle(2186242.0, 0.00057) }, { 3.846658753522248e-06d, new GammaParticle(2161.0, 0.57374) }, { 2.1632640176760346e-05d, new GammaParticle(15691.0, 0.07902) }, { 4.140218215647913e-05d, new GammaParticle(15775.0, 0.0786) }, { 1.0549807088582314e-05d, new GammaParticle(17736.0, 0.06991) }, { 1.209007892351533e-05d, new GammaParticle(17824.0, 0.06956) }, { 1.5402718349330176e-06d, new GammaParticle(17968.0, 0.069) } } },

        };
    }
}
    