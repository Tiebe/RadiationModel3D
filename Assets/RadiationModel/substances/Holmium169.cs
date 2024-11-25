using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium169";
        public override double halfLife { get; } = 283.2d;
        public override double atomicWeight { get; } = 168.93688d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium169() }, { 1.0d, new BetaParticle(-1, 1062599.99999) }, { 0.029036d, new GammaParticle(64550.0, 0.01921) }, { 0.0051849999999999995d, new GammaParticle(67300.0, 0.01842) }, { 0.013481d, new GammaParticle(84900.0, 0.0146) }, { 0.014518d, new GammaParticle(149600.0, 0.00829) }, { 0.055998d, new GammaParticle(151500.0, 0.00818) }, { 0.013481d, new GammaParticle(159590.0, 0.00777) }, { 0.0076738d, new GammaParticle(167400.0, 0.00741) }, { 0.0074664d, new GammaParticle(579600.0, 0.00214) }, { 0.0053924d, new GammaParticle(609600.0, 0.00203) }, { 0.027999d, new GammaParticle(628900.0, 0.00197) }, { 0.0053924d, new GammaParticle(656400.0, 0.00189) }, { 0.0018666d, new GammaParticle(663400.0, 0.00187) }, { 0.042517d, new GammaParticle(676500.0, 0.00183) }, { 0.013481d, new GammaParticle(695000.0, 0.00178) }, { 0.004148d, new GammaParticle(697000.0, 0.00178) }, { 0.009333000000000001d, new GammaParticle(698800.0, 0.00177) }, { 0.013481d, new GammaParticle(705000.0, 0.00176) }, { 0.031628500000000004d, new GammaParticle(717000.0, 0.00173) }, { 0.10369999999999999d, new GammaParticle(761000.0, 0.00163) }, { 0.0049775999999999996d, new GammaParticle(764900.0, 0.00162) }, { 0.012444d, new GammaParticle(773300.0, 0.0016) }, { 0.101626d, new GammaParticle(778400.0, 0.00159) }, { 0.213622d, new GammaParticle(788400.0, 0.00157) }, { 0.010473699999999999d, new GammaParticle(849400.0, 0.00146) }, { 0.113033d, new GammaParticle(852900.0, 0.00145) }, { 0.044591000000000006d, new GammaParticle(866400.0, 0.00143) }, { 0.020739999999999998d, new GammaParticle(876400.0, 0.00141) }, { 0.0053924d, new GammaParticle(1373000.0, 0.0009) }, { 0.0016592000000000002d, new GammaParticle(1442000.0, 0.00086) }, { 0.0014518d, new GammaParticle(1517000.0, 0.00082) }, { 0.0013481d, new GammaParticle(1678000.0, 0.00074) }, { 0.0009333d, new GammaParticle(1769000.0, 0.0007) }, { 0.0021777d, new GammaParticle(1850000.0, 0.00067) }, { 0.07810805992679999d, new GammaParticle(7933.0, 0.15629) }, { 0.07047939405161291d, new GammaParticle(48222.0, 0.02571) }, { 0.12509654606250073d, new GammaParticle(49128.0, 0.02524) }, { 0.04065185612371934d, new GammaParticle(55779.0, 0.02223) }, { 0.05122133871588637d, new GammaParticle(56399.0, 0.02198) }, { 0.010569482592167027d, new GammaParticle(57145.0, 0.0217) } } },

        };
    }
}
    