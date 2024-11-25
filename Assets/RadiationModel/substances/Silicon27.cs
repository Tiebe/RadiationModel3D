using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon27 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon27";
        public override double halfLife { get; } = 4.15d;
        public override double atomicWeight { get; } = 26.9867d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium27() }, { 1.0d, new BetaParticle(1, 1101040.0) }, { 8.999999999999999e-05d, new GammaParticle(170820.0, 0.00726) }, { 4e-05d, new GammaParticle(843760.0, 0.00147) }, { 0.0002d, new GammaParticle(1014520.0, 0.00122) }, { 0.00013d, new GammaParticle(1720300.0, 0.00072) }, { 0.0018d, new GammaParticle(2212010.0, 0.00056) }, { 4e-05d, new GammaParticle(2734700.0, 0.00045) }, { 0.00026d, new GammaParticle(2982000.0, 0.00042) }, { 1e-05d, new GammaParticle(3004000.0, 0.00041) }, { 1.99889d, new GammaParticle(511000.0, 0.00243) }, { 3e-07d, new GammaParticle(91.0, 13.62464) }, { 8e-06d, new GammaParticle(1487.0, 0.83379) }, { 4e-06d, new GammaParticle(1487.0, 0.83379) }, { 3e-07d, new GammaParticle(1558.0, 0.79579) }, { 3e-07d, new GammaParticle(1558.0, 0.79579) } } },

        };
    }
}
    