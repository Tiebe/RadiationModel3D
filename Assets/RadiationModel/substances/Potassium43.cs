using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium43 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium43";
        public override double halfLife { get; } = 80280.0d;
        public override double atomicWeight { get; } = 42.96073d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium43() }, { 1.0d, new BetaParticle(-1, 916735.0) }, { 0.0480004d, new GammaParticle(220632.0, 0.00562) }, { 0.868d, new GammaParticle(372760.0, 0.00333) }, { 0.118482d, new GammaParticle(396861.0, 0.00312) }, { 0.0036456d, new GammaParticle(404214.0, 0.00307) }, { 0.1125796d, new GammaParticle(593390.0, 0.00209) }, { 0.7916160000000001d, new GammaParticle(617490.0, 0.00201) }, { 0.0014755999999999999d, new GammaParticle(801070.0, 0.00155) }, { 0.0028643999999999996d, new GammaParticle(990245.0, 0.00125) }, { 0.0196168d, new GammaParticle(1021698.0, 0.00121) }, { 0.0013106799999999998d, new GammaParticle(1394448.0, 0.00089) }, { 2.488844306505102e-06d, new GammaParticle(358.0, 3.46325) }, { 3.316026156160955e-05d, new GammaParticle(3688.0, 0.33618) }, { 6.552116491130122e-05d, new GammaParticle(3692.0, 0.33582) }, { 1.2789112870889236e-05d, new GammaParticle(4013.0, 0.30896) }, { 1.2789112870889236e-05d, new GammaParticle(4013.0, 0.30896) } } },

        };
    }
}
    