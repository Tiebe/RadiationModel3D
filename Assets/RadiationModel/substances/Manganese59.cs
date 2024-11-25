using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese59 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese59";
        public override double halfLife { get; } = 4.59d;
        public override double atomicWeight { get; } = 58.94039d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron59() }, { 1.0d, new BetaParticle(-1, 2569850.0) }, { 0.039d, new GammaParticle(287030.0, 0.00432) }, { 0.011899999999999999d, new GammaParticle(439220.0, 0.00282) }, { 0.0012d, new GammaParticle(452800.0, 0.00274) }, { 0.22d, new GammaParticle(472740.0, 0.00262) }, { 0.182d, new GammaParticle(570760.0, 0.00217) }, { 0.071d, new GammaParticle(591100.0, 0.0021) }, { 0.0025d, new GammaParticle(689200.0, 0.0018) }, { 0.00021999999999999998d, new GammaParticle(697000.0, 0.00178) }, { 0.31d, new GammaParticle(726300.0, 0.00171) }, { 8.999999999999999e-05d, new GammaParticle(841000.0, 0.00147) }, { 0.021d, new GammaParticle(874820.0, 0.00142) }, { 0.0007000000000000001d, new GammaParticle(1023000.0, 0.00121) }, { 0.0113d, new GammaParticle(1161700.0, 0.00107) }, { 8e-05d, new GammaParticle(1193000.0, 0.00104) }, { 8e-05d, new GammaParticle(1235000.0, 0.001) }, { 0.000248d, new GammaParticle(1545000.0, 0.0008) }, { 0.0034999999999999996d, new GammaParticle(1569400.0, 0.00079) }, { 0.00035000000000000005d, new GammaParticle(1720000.0, 0.00072) }, { 0.00066d, new GammaParticle(1918200.0, 0.00065) }, { 0.0012d, new GammaParticle(2159900.0, 0.00057) }, { 0.0029d, new GammaParticle(2348900.0, 0.00053) }, { 0.00013d, new GammaParticle(2448000.0, 0.00051) }, { 5.06751336e-06d, new GammaParticle(728.0, 1.70308) }, { 5.8429725907340686e-05d, new GammaParticle(6391.0, 0.194) }, { 0.00011441105523270155d, new GammaParticle(6404.0, 0.1936) }, { 2.3644618859957772e-05d, new GammaParticle(7082.0, 0.17507) }, { 2.3644618859957772e-05d, new GammaParticle(7082.0, 0.17507) } } },

        };
    }
}
    