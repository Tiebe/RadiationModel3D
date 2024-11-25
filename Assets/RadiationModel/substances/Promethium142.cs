using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium142";
        public override double halfLife { get; } = 40.5d;
        public override double atomicWeight { get; } = 141.91289d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium142() }, { 1.0d, new BetaParticle(1, 1322200.0) }, { 0.006468000000000001d, new GammaParticle(641400.0, 0.00193) }, { 0.00020459999999999999d, new GammaParticle(809700.0, 0.00153) }, { 0.00020789999999999998d, new GammaParticle(1007900.0, 0.00123) }, { 0.0003102d, new GammaParticle(1552200.0, 0.0008) }, { 0.033d, new GammaParticle(1575800.0, 0.00079) }, { 0.00019800000000000002d, new GammaParticle(1782000.0, 0.0007) }, { 0.001122d, new GammaParticle(2384300.0, 0.00052) }, { 0.00046199999999999995d, new GammaParticle(2583000.0, 0.00048) }, { 0.0007920000000000001d, new GammaParticle(2845900.0, 0.00044) }, { 0.0002145d, new GammaParticle(3045700.0, 0.00041) }, { 0.0001551d, new GammaParticle(3128300.0, 0.0004) }, { 7.59e-05d, new GammaParticle(3358000.0, 0.00037) }, { 1.5545267999999999d, new GammaParticle(511000.0, 0.00243) }, { 0.026699999999999998d, new GammaParticle(5870.0, 0.21122) }, { 0.0493d, new GammaParticle(36848.0, 0.03365) }, { 0.08990000000000001d, new GammaParticle(37362.0, 0.03318) }, { 0.0276d, new GammaParticle(42380.0, 0.02926) }, { 0.0347d, new GammaParticle(42810.0, 0.02896) }, { 0.00709d, new GammaParticle(43335.0, 0.02861) } } },

        };
    }
}
    