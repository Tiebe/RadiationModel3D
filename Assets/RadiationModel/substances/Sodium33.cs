using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium33 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium33";
        public override double halfLife { get; } = 0.008d;
        public override double atomicWeight { get; } = 33.02553d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium33() }, { 1.0d, new BetaParticle(-1, 9408550.0) }, { 0.01914d, new GammaParticle(221000.0, 0.00561) }, { 0.0088d, new GammaParticle(297900.0, 0.00416) }, { 0.041139999999999996d, new GammaParticle(484100.0, 0.00256) }, { 0.08800000000000001d, new GammaParticle(546200.0, 0.00227) }, { 0.05104d, new GammaParticle(704900.0, 0.00176) }, { 0.013420000000000001d, new GammaParticle(758200.0, 0.00164) }, { 0.0055000000000000005d, new GammaParticle(845700.0, 0.00147) }, { 0.0035199999999999997d, new GammaParticle(1011300.0, 0.00123) }, { 0.01562d, new GammaParticle(1242800.0, 0.001) }, { 0.00902d, new GammaParticle(1857700.0, 0.00067) }, { 0.01474d, new GammaParticle(1976900.0, 0.00063) }, { 0.0154d, new GammaParticle(2236900.0, 0.00055) } } },
            { 0.47d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium33() }, { 1.0d, new BetaParticle(-1, 9408550.0) }, { 0.01914d, new GammaParticle(221000.0, 0.00561) }, { 0.0088d, new GammaParticle(297900.0, 0.00416) }, { 0.041139999999999996d, new GammaParticle(484100.0, 0.00256) }, { 0.08800000000000001d, new GammaParticle(546200.0, 0.00227) }, { 0.05104d, new GammaParticle(704900.0, 0.00176) }, { 0.013420000000000001d, new GammaParticle(758200.0, 0.00164) }, { 0.0055000000000000005d, new GammaParticle(845700.0, 0.00147) }, { 0.0035199999999999997d, new GammaParticle(1011300.0, 0.00123) }, { 0.01562d, new GammaParticle(1242800.0, 0.001) }, { 0.00902d, new GammaParticle(1857700.0, 0.00067) }, { 0.01474d, new GammaParticle(1976900.0, 0.00063) }, { 0.0154d, new GammaParticle(2236900.0, 0.00055) } } },
            { 0.13d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium31() }, { 1.0d, new BetaParticle(-1, 944945103.472) }, { 1.0d, new NeutronParticle() }, { 0.018000000000000002d, new GammaParticle(50100.0, 0.02475) }, { 0.0077d, new GammaParticle(171200.0, 0.00724) }, { 0.0031d, new GammaParticle(221000.0, 0.00561) }, { 1.381562904e-07d, new GammaParticle(46.0, 26.95309) }, { 2.2015680304362136e-06d, new GammaParticle(1254.0, 0.98871) }, { 4.376004830920719e-06d, new GammaParticle(1254.0, 0.98871) } } },

        };
    }
}
    