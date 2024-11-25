using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine23 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine23";
        public override double halfLife { get; } = 2.23d;
        public override double atomicWeight { get; } = 23.00353d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon23() }, { 1.0d, new BetaParticle(-1, 4222025.0) }, { 0.032400000000000005d, new GammaParticle(493000.0, 0.00251) }, { 0.07440000000000001d, new GammaParticle(815200.0, 0.00152) }, { 0.0603d, new GammaParticle(1016700.0, 0.00122) }, { 0.3d, new GammaParticle(1701440.0, 0.00073) }, { 0.1422d, new GammaParticle(1822250.0, 0.00068) }, { 0.0579d, new GammaParticle(1919300.0, 0.00065) }, { 0.204d, new GammaParticle(2128800.0, 0.00058) }, { 0.0231d, new GammaParticle(2314200.0, 0.00054) }, { 0.0444d, new GammaParticle(2414300.0, 0.00051) }, { 0.0087d, new GammaParticle(2515900.0, 0.00049) }, { 0.035699999999999996d, new GammaParticle(2734200.0, 0.00045) }, { 0.0762d, new GammaParticle(3431400.0, 0.00036) }, { 0.0204d, new GammaParticle(3830700.0, 0.00032) } } },
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon23() }, { 1.0d, new BetaParticle(-1, 4222025.0) }, { 0.032400000000000005d, new GammaParticle(493000.0, 0.00251) }, { 0.07440000000000001d, new GammaParticle(815200.0, 0.00152) }, { 0.0603d, new GammaParticle(1016700.0, 0.00122) }, { 0.3d, new GammaParticle(1701440.0, 0.00073) }, { 0.1422d, new GammaParticle(1822250.0, 0.00068) }, { 0.0579d, new GammaParticle(1919300.0, 0.00065) }, { 0.204d, new GammaParticle(2128800.0, 0.00058) }, { 0.0231d, new GammaParticle(2314200.0, 0.00054) }, { 0.0444d, new GammaParticle(2414300.0, 0.00051) }, { 0.0087d, new GammaParticle(2515900.0, 0.00049) }, { 0.035699999999999996d, new GammaParticle(2734200.0, 0.00045) }, { 0.0762d, new GammaParticle(3431400.0, 0.00036) }, { 0.0204d, new GammaParticle(3830700.0, 0.00032) } } },

        };
    }
}
    