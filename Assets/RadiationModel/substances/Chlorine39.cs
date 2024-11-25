using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine39 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine39";
        public override double halfLife { get; } = 3372.0d;
        public override double atomicWeight { get; } = 38.96801d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon39() }, { 1.0d, new BetaParticle(-1, 1720900.0) }, { 1.3e-05d, new GammaParticle(198300.0, 0.00625) }, { 0.461d, new GammaParticle(250333.0, 0.00495) }, { 8e-06d, new GammaParticle(306200.0, 0.00405) }, { 8e-05d, new GammaParticle(326500.0, 0.0038) }, { 0.00043999999999999996d, new GammaParticle(396460.0, 0.00313) }, { 0.00096d, new GammaParticle(410690.0, 0.00302) }, { 0.00014000000000000001d, new GammaParticle(446610.0, 0.00278) }, { 4e-05d, new GammaParticle(471600.0, 0.00263) }, { 1.1000000000000001e-05d, new GammaParticle(538800.0, 0.0023) }, { 8.999999999999999e-05d, new GammaParticle(825533.0, 0.0015) }, { 0.00133d, new GammaParticle(840775.0, 0.00147) }, { 5e-05d, new GammaParticle(915860.0, 0.00135) }, { 0.0209d, new GammaParticle(985861.0, 0.00126) }, { 0.0242d, new GammaParticle(1091056.0, 0.00114) }, { 0.00031d, new GammaParticle(1166250.0, 0.00106) }, { 0.0006d, new GammaParticle(1236190.0, 0.001) }, { 0.536d, new GammaParticle(1267191.0, 0.00098) }, { 0.00252d, new GammaParticle(1312360.0, 0.00094) }, { 0.000129d, new GammaParticle(1432270.0, 0.00087) }, { 0.39299999999999996d, new GammaParticle(1517498.0, 0.00082) }, { 0.0028699999999999997d, new GammaParticle(1562704.0, 0.00079) }, { 1.9e-05d, new GammaParticle(2019700.0, 0.00061) }, { 0.0009299999999999999d, new GammaParticle(2092740.0, 0.00059) }, { 5e-06d, new GammaParticle(2342100.0, 0.00053) }, { 3e-05d, new GammaParticle(2358200.0, 0.00053) }, { 0.000112d, new GammaParticle(2433490.0, 0.00051) }, { 1.1000000000000001e-05d, new GammaParticle(2481400.0, 0.0005) }, { 5.4000000000000005e-05d, new GammaParticle(2503280.0, 0.0005) }, { 8e-06d, new GammaParticle(2523600.0, 0.00049) }, { 5e-06d, new GammaParticle(2651000.0, 0.00047) }, { 1.3e-05d, new GammaParticle(2755400.0, 0.00045) }, { 8e-06d, new GammaParticle(2830200.0, 0.00044) }, { 1.13002165311e-06d, new GammaParticle(265.0, 4.67865) }, { 1.569060942059891e-05d, new GammaParticle(2956.0, 0.41943) }, { 3.107666749970075e-05d, new GammaParticle(2958.0, 0.41915) }, { 5.046189179700333e-06d, new GammaParticle(3190.0, 0.38867) }, { 5.046189179700333e-06d, new GammaParticle(3190.0, 0.38867) } } },

        };
    }
}
    