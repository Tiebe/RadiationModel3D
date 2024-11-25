using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium65 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium65";
        public override double halfLife { get; } = 0.033d;
        public override double atomicWeight { get; } = 64.96455d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium65() }, { 1.0d, new BetaParticle(1, 11729100.0) }, { 0.96d, new GammaParticle(511000.0, 0.00243) }, { 1.04032032e-05d, new GammaParticle(1320.0, 0.93927) }, { 8.439578413274689e-05d, new GammaParticle(10509.0, 0.11798) }, { 0.00016377990322675507d, new GammaParticle(10544.0, 0.11759) }, { 3.744874989448642e-05d, new GammaParticle(11773.0, 0.10531) }, { 3.886431264049801e-05d, new GammaParticle(11791.0, 0.10515) }, { 1.415562746011587e-06d, new GammaParticle(11861.0, 0.10453) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium64() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    