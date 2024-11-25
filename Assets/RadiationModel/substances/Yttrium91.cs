using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium91";
        public override double halfLife { get; } = 5055264.0d;
        public override double atomicWeight { get; } = 90.9073d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium91() }, { 1.0d, new BetaParticle(-1, 772145.0) }, { 0.0026d, new GammaParticle(1204800.0, 0.00103) }, { 3.787231968e-08d, new GammaParticle(2161.0, 0.57374) }, { 2.1541755250919597e-07d, new GammaParticle(15691.0, 0.07902) }, { 4.1228239714678657e-07d, new GammaParticle(15775.0, 0.0786) }, { 1.0505484323212691e-07d, new GammaParticle(17736.0, 0.06991) }, { 1.2039285034401745e-07d, new GammaParticle(17824.0, 0.06956) }, { 1.5338007111890528e-08d, new GammaParticle(17968.0, 0.069) } } },

        };
    }
}
    