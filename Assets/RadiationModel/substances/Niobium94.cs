using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium94";
        public override double halfLife { get; } = 640605597284.2177d;
        public override double atomicWeight { get; } = 93.90728d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum94() }, { 1.0d, new BetaParticle(-1, 1022490.0) }, { 0.998d, new GammaParticle(702650.0, 0.00176) }, { 0.998d, new GammaParticle(871091.0, 0.00142) }, { 0.00011117969001000001d, new GammaParticle(2440.0, 0.50813) }, { 0.0005604262590969499d, new GammaParticle(17374.0, 0.07136) }, { 0.001068088925284829d, new GammaParticle(17479.0, 0.07093) }, { 0.0002802626651804344d, new GammaParticle(19681.0, 0.063) }, { 0.0003234231156182213d, new GammaParticle(19794.0, 0.06264) }, { 4.31604504377869e-05d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    