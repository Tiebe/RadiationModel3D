using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic86 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic86";
        public override double halfLife { get; } = 0.945d;
        public override double atomicWeight { get; } = 85.9367d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium86() }, { 1.0d, new BetaParticle(-1, 5770600.0) }, { 0.0066d, new GammaParticle(505000.0, 0.00246) }, { 0.0011d, new GammaParticle(674200.0, 0.00184) }, { 0.0528d, new GammaParticle(694650.0, 0.00178) }, { 0.22d, new GammaParticle(704300.0, 0.00176) }, { 0.00198d, new GammaParticle(782200.0, 0.00159) }, { 0.022000000000000002d, new GammaParticle(863400.0, 0.00144) }, { 0.00462d, new GammaParticle(973300.0, 0.00127) }, { 0.0242d, new GammaParticle(1399100.0, 0.00089) }, { 0.0088d, new GammaParticle(1476200.0, 0.00084) }, { 0.0176d, new GammaParticle(1504000.0, 0.00082) }, { 0.0242d, new GammaParticle(1668000.0, 0.00074) }, { 0.0033d, new GammaParticle(1864800.0, 0.00066) }, { 0.0022d, new GammaParticle(2028700.0, 0.00061) }, { 0.00066d, new GammaParticle(2208000.0, 0.00056) }, { 0.0066d, new GammaParticle(3384200.0, 0.00037) }, { 0.0132d, new GammaParticle(3532400.0, 0.00035) }, { 4.846591749999999e-06d, new GammaParticle(1426.0, 0.86945) }, { 3.731032453908798e-05d, new GammaParticle(11183.0, 0.11087) }, { 7.233486727236909e-05d, new GammaParticle(11223.0, 0.11047) }, { 1.6879670695458168e-05d, new GammaParticle(12546.0, 0.09882) }, { 1.782830818854292e-05d, new GammaParticle(12571.0, 0.09863) }, { 9.48637493084749e-07d, new GammaParticle(12652.0, 0.098) } } },
            { 0.355d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium86() }, { 1.0d, new BetaParticle(-1, 5770600.0) }, { 0.0066d, new GammaParticle(505000.0, 0.00246) }, { 0.0011d, new GammaParticle(674200.0, 0.00184) }, { 0.0528d, new GammaParticle(694650.0, 0.00178) }, { 0.22d, new GammaParticle(704300.0, 0.00176) }, { 0.00198d, new GammaParticle(782200.0, 0.00159) }, { 0.022000000000000002d, new GammaParticle(863400.0, 0.00144) }, { 0.00462d, new GammaParticle(973300.0, 0.00127) }, { 0.0242d, new GammaParticle(1399100.0, 0.00089) }, { 0.0088d, new GammaParticle(1476200.0, 0.00084) }, { 0.0176d, new GammaParticle(1504000.0, 0.00082) }, { 0.0242d, new GammaParticle(1668000.0, 0.00074) }, { 0.0033d, new GammaParticle(1864800.0, 0.00066) }, { 0.0022d, new GammaParticle(2028700.0, 0.00061) }, { 0.00066d, new GammaParticle(2208000.0, 0.00056) }, { 0.0066d, new GammaParticle(3384200.0, 0.00037) }, { 0.0132d, new GammaParticle(3532400.0, 0.00035) }, { 4.846591749999999e-06d, new GammaParticle(1426.0, 0.86945) }, { 3.731032453908798e-05d, new GammaParticle(11183.0, 0.11087) }, { 7.233486727236909e-05d, new GammaParticle(11223.0, 0.11047) }, { 1.6879670695458168e-05d, new GammaParticle(12546.0, 0.09882) }, { 1.782830818854292e-05d, new GammaParticle(12571.0, 0.09863) }, { 9.48637493084749e-07d, new GammaParticle(12652.0, 0.098) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    