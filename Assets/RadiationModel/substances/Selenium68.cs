using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium68 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium68";
        public override double halfLife { get; } = 35.5d;
        public override double atomicWeight { get; } = 67.94183d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium68() }, { 1.0d, new BetaParticle(1, 6394700.0) }, { 0.0017865000000000001d, new GammaParticle(49500.0, 0.02505) }, { 0.07543d, new GammaParticle(72600.0, 0.01708) }, { 0.397d, new GammaParticle(111400.0, 0.01113) }, { 0.0794d, new GammaParticle(155100.0, 0.00799) }, { 0.08337d, new GammaParticle(158100.0, 0.00784) }, { 0.32156999999999997d, new GammaParticle(160800.0, 0.00771) }, { 0.078606d, new GammaParticle(192200.0, 0.00645) }, { 0.023423d, new GammaParticle(202700.0, 0.00612) }, { 0.007940000000000001d, new GammaParticle(205600.0, 0.00603) }, { 0.18658999999999998d, new GammaParticle(265000.0, 0.00468) }, { 0.44860999999999995d, new GammaParticle(314500.0, 0.00394) }, { 0.051609999999999996d, new GammaParticle(352600.0, 0.00352) }, { 0.051609999999999996d, new GammaParticle(426100.0, 0.00291) }, { 2.144d, new GammaParticle(511000.0, 0.00243) }, { 0.006d, new GammaParticle(1320.0, 0.93927) }, { 0.048d, new GammaParticle(10509.0, 0.11798) }, { 0.09300000000000001d, new GammaParticle(10544.0, 0.11759) }, { 0.0213d, new GammaParticle(11773.0, 0.10531) }, { 0.022099999999999998d, new GammaParticle(11791.0, 0.10515) }, { 0.0008100000000000001d, new GammaParticle(11861.0, 0.10453) } } },

        };
    }
}
    