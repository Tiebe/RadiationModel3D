using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium50 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium50";
        public override double halfLife { get; } = 102.5d;
        public override double atomicWeight { get; } = 49.95219d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium50() }, { 1.0d, new BetaParticle(-1, 3447385.0) }, { 0.887d, new GammaParticle(523792.0, 0.00237) }, { 0.995d, new GammaParticle(1121124.0, 0.00111) }, { 0.0060999999999999995d, new GammaParticle(1472360.0, 0.00084) }, { 1.0d, new GammaParticle(1553768.0, 0.0008) }, { 0.0028000000000000004d, new GammaParticle(1681950.0, 0.00074) }, { 0.0127d, new GammaParticle(2205840.0, 0.00056) }, { 0.00105d, new GammaParticle(2705150.0, 0.00046) }, { 0.00145d, new GammaParticle(2765730.0, 0.00045) }, { 0.00251d, new GammaParticle(3132210.0, 0.0004) }, { 0.00043999999999999996d, new GammaParticle(3825990.0, 0.00032) }, { 3.8556373247375525e-06d, new GammaParticle(477.0, 2.59925) }, { 4.8731943058793395e-05d, new GammaParticle(4505.0, 0.27521) }, { 9.600461595506973e-05d, new GammaParticle(4511.0, 0.27485) }, { 1.9177594069336865e-05d, new GammaParticle(4947.0, 0.25063) }, { 1.9177594069336865e-05d, new GammaParticle(4947.0, 0.25063) } } },

        };
    }
}
    