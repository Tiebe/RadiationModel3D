using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt62m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt62m";
        public override double halfLife { get; } = 831.6d;
        public override double atomicWeight { get; } = 61.93408d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel62() }, { 1.0d, new BetaParticle(-1, 2672200.0) }, { 0.0176d, new GammaParticle(777500.0, 0.00159) }, { 0.0127d, new GammaParticle(875000.0, 0.00142) }, { 0.0127d, new GammaParticle(1128900.0, 0.0011) }, { 0.705d, new GammaParticle(1163500.0, 0.00107) }, { 0.977d, new GammaParticle(1172900.0, 0.00106) }, { 0.067d, new GammaParticle(1718700.0, 0.00072) }, { 0.0059d, new GammaParticle(1753500.0, 0.00071) }, { 0.182d, new GammaParticle(2003700.0, 0.00062) }, { 0.067d, new GammaParticle(2104900.0, 0.00059) }, { 0.0176d, new GammaParticle(2301900.0, 0.00054) }, { 0.0109d, new GammaParticle(2882300.0, 0.00043) }, { 0.0029d, new GammaParticle(3271100.0, 0.00038) }, { 3.3722624520479997e-06d, new GammaParticle(874.0, 1.41858) }, { 3.387499395375914e-05d, new GammaParticle(7461.0, 0.16618) }, { 6.611044877782815e-05d, new GammaParticle(7478.0, 0.1658) }, { 1.3777994008412727e-05d, new GammaParticle(8296.0, 0.14945) }, { 1.3777994008412727e-05d, new GammaParticle(8296.0, 0.14945) } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt62() } } },

        };
    }
}
    