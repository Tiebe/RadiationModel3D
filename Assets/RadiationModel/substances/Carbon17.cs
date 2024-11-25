using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon17 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon17";
        public override double halfLife { get; } = 0.193d;
        public override double atomicWeight { get; } = 17.02258d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen17() }, { 1.0d, new BetaParticle(-1, 6581000.0) }, { 0.034d, new GammaParticle(475700.0, 0.00261) }, { 0.021d, new GammaParticle(532900.0, 0.00233) }, { 0.053d, new GammaParticle(619200.0, 0.002) }, { 0.016d, new GammaParticle(676400.0, 0.00183) }, { 0.044000000000000004d, new GammaParticle(1152100.0, 0.00108) }, { 0.24d, new GammaParticle(1373800.0, 0.0009) }, { 0.22d, new GammaParticle(1849500.0, 0.00067) }, { 0.07d, new GammaParticle(1906700.0, 0.00065) }, { 0.013999999999999999d, new GammaParticle(2525800.0, 0.00049) } } },
            { 0.26d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nitrogen17() }, { 1.0d, new BetaParticle(-1, 6581000.0) }, { 0.034d, new GammaParticle(475700.0, 0.00261) }, { 0.021d, new GammaParticle(532900.0, 0.00233) }, { 0.053d, new GammaParticle(619200.0, 0.002) }, { 0.016d, new GammaParticle(676400.0, 0.00183) }, { 0.044000000000000004d, new GammaParticle(1152100.0, 0.00108) }, { 0.24d, new GammaParticle(1373800.0, 0.0009) }, { 0.22d, new GammaParticle(1849500.0, 0.00067) }, { 0.07d, new GammaParticle(1906700.0, 0.00065) }, { 0.013999999999999999d, new GammaParticle(2525800.0, 0.00049) } } },

        };
    }
}
    