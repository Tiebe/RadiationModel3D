using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen20 : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen20";
        public override double halfLife { get; } = 13.51d;
        public override double atomicWeight { get; } = 20.00408d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fluorine20() }, { 1.0d, new BetaParticle(-1, 1906831.5) }, { 1e-06d, new GammaParticle(325730.0, 0.00381) }, { 1e-06d, new GammaParticle(653200.0, 0.0019) }, { 2e-06d, new GammaParticle(656000.0, 0.00189) }, { 1.1000000000000001e-05d, new GammaParticle(983530.0, 0.00126) }, { 0.9997499999999999d, new GammaParticle(1056780.0, 0.00117) }, { 1e-06d, new GammaParticle(1187700.0, 0.00104) }, { 2.3e-05d, new GammaParticle(1309170.0, 0.00095) }, { 2e-05d, new GammaParticle(1644500.0, 0.00075) }, { 1.8e-05d, new GammaParticle(1843740.0, 0.00067) }, { 2.5e-05d, new GammaParticle(2179090.0, 0.00057) }, { 1.9e-05d, new GammaParticle(2431430.0, 0.00051) }, { 1e-05d, new GammaParticle(2504540.0, 0.0005) }, { 0.000196d, new GammaParticle(3488130.0, 0.00036) } } },

        };
    }
}
    