using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen12 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen12";
        public override double halfLife { get; } = 0.011d;
        public override double atomicWeight { get; } = 12.01861d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Boron12() }, { 1.0d, new BetaParticle(1, 1984350.0) }, { 5.9e-06d, new GammaParticle(3213800.0, 0.00039) }, { 0.019d, new GammaParticle(4438910.0, 0.00028) }, { 2.000066d, new GammaParticle(511000.0, 0.00243) } } },
            { 0.019299999999999998d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon12() }, { 1.0d, new BetaParticle(1, 8669050.0) } } },

        };
    }
}
    