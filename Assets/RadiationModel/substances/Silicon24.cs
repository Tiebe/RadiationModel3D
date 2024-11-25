using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon24 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon24";
        public override double halfLife { get; } = 0.1413d;
        public override double atomicWeight { get; } = 24.01154d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium24() }, { 1.0d, new BetaParticle(1, 12339289.0) }, { 1.964d, new GammaParticle(511000.0, 0.00243) }, { 9.8875714224e-08d, new GammaParticle(91.0, 13.62464) }, { 1.486563890535826e-06d, new GammaParticle(1487.0, 0.83379) }, { 2.9536337980048204e-06d, new GammaParticle(1487.0, 0.83379) }, { 9.324415145935358e-08d, new GammaParticle(1558.0, 0.79579) }, { 9.324415145935358e-08d, new GammaParticle(1558.0, 0.79579) } } },
            { 0.324d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium23() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    