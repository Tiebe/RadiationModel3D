using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium31 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium31";
        public override double halfLife { get; } = 0.27d;
        public override double atomicWeight { get; } = 30.99665d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum31() }, { 1.0d, new BetaParticle(-1, 5914350.0) }, { 0.141d, new GammaParticle(665900.0, 0.00186) }, { 0.023d, new GammaParticle(903800.0, 0.00137) }, { 0.37d, new GammaParticle(946700.0, 0.00131) }, { 0.44799999999999995d, new GammaParticle(1612800.0, 0.00077) }, { 0.305d, new GammaParticle(1626200.0, 0.00076) }, { 0.05d, new GammaParticle(1820000.0, 0.00068) }, { 0.0052d, new GammaParticle(2291700.0, 0.00054) }, { 0.0184d, new GammaParticle(2487400.0, 0.0005) }, { 0.04d, new GammaParticle(2529700.0, 0.00049) }, { 0.034d, new GammaParticle(2675800.0, 0.00046) }, { 0.054000000000000006d, new GammaParticle(2949400.0, 0.00042) }, { 0.057d, new GammaParticle(3196600.0, 0.00039) }, { 0.045d, new GammaParticle(3432800.0, 0.00036) }, { 0.035d, new GammaParticle(3433300.0, 0.00036) }, { 0.018000000000000002d, new GammaParticle(3617700.0, 0.00034) }, { 0.08d, new GammaParticle(3623000.0, 0.00034) }, { 0.013000000000000001d, new GammaParticle(3693000.0, 0.00034) }, { 0.0049d, new GammaParticle(4143200.0, 0.0003) }, { 0.028999999999999998d, new GammaParticle(4202700.0, 0.0003) }, { 0.0076d, new GammaParticle(4563500.0, 0.00027) }, { 0.0028000000000000004d, new GammaParticle(4640300.0, 0.00027) }, { 0.0103d, new GammaParticle(4808700.0, 0.00026) } } },
            { 0.062d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum31() }, { 1.0d, new BetaParticle(-1, 5914350.0) }, { 0.141d, new GammaParticle(665900.0, 0.00186) }, { 0.023d, new GammaParticle(903800.0, 0.00137) }, { 0.37d, new GammaParticle(946700.0, 0.00131) }, { 0.44799999999999995d, new GammaParticle(1612800.0, 0.00077) }, { 0.305d, new GammaParticle(1626200.0, 0.00076) }, { 0.05d, new GammaParticle(1820000.0, 0.00068) }, { 0.0052d, new GammaParticle(2291700.0, 0.00054) }, { 0.0184d, new GammaParticle(2487400.0, 0.0005) }, { 0.04d, new GammaParticle(2529700.0, 0.00049) }, { 0.034d, new GammaParticle(2675800.0, 0.00046) }, { 0.054000000000000006d, new GammaParticle(2949400.0, 0.00042) }, { 0.057d, new GammaParticle(3196600.0, 0.00039) }, { 0.045d, new GammaParticle(3432800.0, 0.00036) }, { 0.035d, new GammaParticle(3433300.0, 0.00036) }, { 0.018000000000000002d, new GammaParticle(3617700.0, 0.00034) }, { 0.08d, new GammaParticle(3623000.0, 0.00034) }, { 0.013000000000000001d, new GammaParticle(3693000.0, 0.00034) }, { 0.0049d, new GammaParticle(4143200.0, 0.0003) }, { 0.028999999999999998d, new GammaParticle(4202700.0, 0.0003) }, { 0.0076d, new GammaParticle(4563500.0, 0.00027) }, { 0.0028000000000000004d, new GammaParticle(4640300.0, 0.00027) }, { 0.0103d, new GammaParticle(4808700.0, 0.00026) } } },

        };
    }
}
    