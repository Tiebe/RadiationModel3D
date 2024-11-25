using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron12 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron12";
        public override double halfLife { get; } = 0.0202d;
        public override double atomicWeight { get; } = 12.01435d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon12() }, { 1.0d, new BetaParticle(-1, 6684700.0) }, { 2.3e-06d, new GammaParticle(3216900.0, 0.00039) }, { 0.011819999999999999d, new GammaParticle(4438910.0, 0.00028) } } },
            { 0.006d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon12() }, { 1.0d, new BetaParticle(-1, 6684700.0) }, { 2.3e-06d, new GammaParticle(3216900.0, 0.00039) }, { 0.011819999999999999d, new GammaParticle(4438910.0, 0.00028) } } },

        };
    }
}
    