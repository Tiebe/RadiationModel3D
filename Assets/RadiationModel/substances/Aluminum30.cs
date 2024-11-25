using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum30 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum30";
        public override double halfLife { get; } = 3.62d;
        public override double atomicWeight { get; } = 29.98297d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon30() }, { 1.0d, new BetaParticle(-1, 4284431.0) }, { 0.0007000000000000001d, new GammaParticle(400200.0, 0.0031) }, { 0.001d, new GammaParticle(421000.0, 0.00294) }, { 7e-06d, new GammaParticle(671000.0, 0.00185) }, { 5e-06d, new GammaParticle(719000.0, 0.00172) }, { 0.0001d, new GammaParticle(783000.0, 0.00158) }, { 3e-05d, new GammaParticle(804000.0, 0.00154) }, { 0.002d, new GammaParticle(1039000.0, 0.00119) }, { 2.5e-05d, new GammaParticle(1120000.0, 0.00111) }, { 0.406d, new GammaParticle(1263130.0, 0.00098) }, { 0.019d, new GammaParticle(1311800.0, 0.00095) }, { 0.009300000000000001d, new GammaParticle(1332480.0, 0.00093) }, { 0.0016d, new GammaParticle(1534120.0, 0.00081) }, { 0.0187d, new GammaParticle(1732300.0, 0.00072) }, { 0.0016d, new GammaParticle(1844400.0, 0.00067) }, { 0.65d, new GammaParticle(2235230.0, 0.00055) }, { 7.000000000000001e-05d, new GammaParticle(2452600.0, 0.00051) }, { 0.0096d, new GammaParticle(2574800.0, 0.00048) }, { 0.0579d, new GammaParticle(2595390.0, 0.00048) }, { 0.0023d, new GammaParticle(2995000.0, 0.00041) }, { 0.0016d, new GammaParticle(3043200.0, 0.00041) }, { 0.0012d, new GammaParticle(3378680.0, 0.00037) }, { 0.33d, new GammaParticle(3498330.0, 0.00035) }, { 0.0014000000000000002d, new GammaParticle(3716000.0, 0.00033) }, { 0.0014000000000000002d, new GammaParticle(3769220.0, 0.00033) }, { 0.0213d, new GammaParticle(4810000.0, 0.00026) }, { 1.2e-08d, new GammaParticle(118.0, 10.50714) }, { 3.64e-07d, new GammaParticle(1740.0, 0.71255) }, { 1.83e-07d, new GammaParticle(1740.0, 0.71255) }, { 1.59e-08d, new GammaParticle(1836.0, 0.6753) }, { 1.59e-08d, new GammaParticle(1836.0, 0.6753) } } },

        };
    }
}
    