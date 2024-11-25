using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium78 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium78";
        public override double halfLife { get; } = 5.09d;
        public override double atomicWeight { get; } = 77.93161d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium78() }, { 1.0d, new BetaParticle(-1, 4078950.0) }, { 0.05236d, new GammaParticle(345760.0, 0.00359) }, { 0.05852d, new GammaParticle(458000.0, 0.00271) }, { 0.002387d, new GammaParticle(532700.0, 0.00233) }, { 0.18248999999999999d, new GammaParticle(567060.0, 0.00219) }, { 0.77d, new GammaParticle(619400.0, 0.002) }, { 0.06314d, new GammaParticle(674860.0, 0.00184) }, { 0.00847d, new GammaParticle(862800.0, 0.00144) }, { 0.003388d, new GammaParticle(891300.0, 0.00139) }, { 0.010009999999999998d, new GammaParticle(927200.0, 0.00134) }, { 0.07546d, new GammaParticle(950770.0, 0.0013) }, { 0.0077d, new GammaParticle(962500.0, 0.00129) }, { 0.01232d, new GammaParticle(1021200.0, 0.00121) }, { 0.12397d, new GammaParticle(1025110.0, 0.00121) }, { 0.006776d, new GammaParticle(1061900.0, 0.00117) }, { 0.20097d, new GammaParticle(1186420.0, 0.00105) }, { 0.020019999999999996d, new GammaParticle(1212410.0, 0.00102) }, { 0.0462d, new GammaParticle(1223360.0, 0.00101) }, { 0.01848d, new GammaParticle(1251960.0, 0.00099) }, { 0.003542d, new GammaParticle(1308400.0, 0.00095) }, { 0.0069299999999999995d, new GammaParticle(1382600.0, 0.0009) }, { 0.013859999999999999d, new GammaParticle(1475500.0, 0.00084) }, { 0.08239d, new GammaParticle(1479130.0, 0.00084) }, { 0.015939000000000002d, new GammaParticle(1519320.0, 0.00082) }, { 0.012012d, new GammaParticle(1564200.0, 0.00079) }, { 0.010395000000000001d, new GammaParticle(1573400.0, 0.00079) }, { 0.016016d, new GammaParticle(1604380.0, 0.00077) }, { 0.01617d, new GammaParticle(1670670.0, 0.00074) }, { 0.00847d, new GammaParticle(1675200.0, 0.00074) }, { 0.007238d, new GammaParticle(1745400.0, 0.00071) }, { 0.0077d, new GammaParticle(1819590.0, 0.00068) }, { 0.02849d, new GammaParticle(1819590.0, 0.00068) }, { 0.09317d, new GammaParticle(1934100.0, 0.00064) }, { 0.01309d, new GammaParticle(2043100.0, 0.00061) }, { 0.055439999999999996d, new GammaParticle(2046320.0, 0.00061) }, { 0.01232d, new GammaParticle(2237900.0, 0.00055) }, { 0.00847d, new GammaParticle(2241000.0, 0.00055) }, { 0.01771d, new GammaParticle(2333300.0, 0.00053) }, { 0.010318d, new GammaParticle(2358300.0, 0.00053) }, { 0.02541d, new GammaParticle(2501400.0, 0.0005) }, { 0.00616d, new GammaParticle(2501400.0, 0.0005) }, { 0.03388d, new GammaParticle(2706200.0, 0.00046) }, { 0.01309d, new GammaParticle(2771200.0, 0.00045) }, { 0.003927d, new GammaParticle(3083000.0, 0.0004) }, { 0.01771d, new GammaParticle(3092800.0, 0.0004) }, { 0.043890000000000005d, new GammaParticle(3464300.0, 0.00036) }, { 0.0009239999999999999d, new GammaParticle(3508400.0, 0.00035) }, { 0.01309d, new GammaParticle(4458500.0, 0.00028) }, { 2.270929010196e-05d, new GammaParticle(1221.0, 1.01543) }, { 0.00019132120389591406d, new GammaParticle(9856.0, 0.1258) }, { 0.00037156963273628685d, new GammaParticle(9887.0, 0.1254) }, { 8.311176834422614e-05d, new GammaParticle(11026.0, 0.11245) }, { 8.494022724779912e-05d, new GammaParticle(11038.0, 0.11232) }, { 1.8284589035729753e-06d, new GammaParticle(11099.0, 0.11171) } } },

        };
    }
}
    