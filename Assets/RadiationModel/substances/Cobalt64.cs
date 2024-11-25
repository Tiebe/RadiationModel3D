using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt64 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt64";
        public override double halfLife { get; } = 0.3d;
        public override double atomicWeight { get; } = 63.93581d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel64() }, { 1.0d, new BetaParticle(-1, 3653500.0) }, { 0.00045d, new GammaParticle(278600.0, 0.00445) }, { 0.000375d, new GammaParticle(688000.0, 0.0018) }, { 0.0006d, new GammaParticle(695700.0, 0.00178) }, { 0.00435d, new GammaParticle(702200.0, 0.00177) }, { 0.0014249999999999998d, new GammaParticle(877200.0, 0.00141) }, { 0.030525000000000004d, new GammaParticle(930800.0, 0.00133) }, { 0.001725d, new GammaParticle(1114600.0, 0.00111) }, { 0.075d, new GammaParticle(1345800.0, 0.00092) }, { 0.005699999999999999d, new GammaParticle(1521600.0, 0.00081) }, { 0.00075d, new GammaParticle(1626300.0, 0.00076) }, { 0.0023250000000000002d, new GammaParticle(1680100.0, 0.00074) }, { 0.0018d, new GammaParticle(1808000.0, 0.00069) }, { 0.000225d, new GammaParticle(1930200.0, 0.00064) }, { 0.000525d, new GammaParticle(2232900.0, 0.00056) }, { 0.00075d, new GammaParticle(2276600.0, 0.00054) }, { 0.000375d, new GammaParticle(2922100.0, 0.00042) }, { 0.00045d, new GammaParticle(2972000.0, 0.00042) }, { 0.0024749999999999998d, new GammaParticle(3153700.0, 0.00039) }, { 0.0009d, new GammaParticle(3210500.0, 0.00039) }, { 0.00165d, new GammaParticle(3275900.0, 0.00038) }, { 0.000225d, new GammaParticle(3578300.0, 0.00035) }, { 2.00212796196e-07d, new GammaParticle(874.0, 1.41858) }, { 2.0112591079571008e-06d, new GammaParticle(7461.0, 0.16618) }, { 3.925173903116902e-06d, new GammaParticle(7478.0, 0.1658) }, { 8.180404689259977e-07d, new GammaParticle(8296.0, 0.14945) }, { 8.180404689259977e-07d, new GammaParticle(8296.0, 0.14945) } } },

        };
    }
}
    