using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium64 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium64";
        public override double halfLife { get; } = 63.7d;
        public override double atomicWeight { get; } = 63.94169d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc64() }, { 1.0d, new BetaParticle(1, 5844000.0) }, { 0.006999999999999999d, new GammaParticle(42890.0, 0.02891) }, { 0.039d, new GammaParticle(85290.0, 0.01454) }, { 0.107d, new GammaParticle(128200.0, 0.00967) }, { 0.047d, new GammaParticle(384100.0, 0.00323) }, { 0.374d, new GammaParticle(427000.0, 0.0029) }, { 0.16899999999999998d, new GammaParticle(667100.0, 0.00186) }, { 0.07d, new GammaParticle(774500.0, 0.0016) }, { 1.66d, new GammaParticle(511000.0, 0.00243) }, { 0.0025d, new GammaParticle(1127.0, 1.10013) }, { 0.022000000000000002d, new GammaParticle(9225.0, 0.1344) }, { 0.042d, new GammaParticle(9252.0, 0.13401) }, { 0.009000000000000001d, new GammaParticle(10306.0, 0.1203) }, { 0.009000000000000001d, new GammaParticle(10313.0, 0.12022) }, { 5.4999999999999995e-05d, new GammaParticle(10365.0, 0.11962) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    