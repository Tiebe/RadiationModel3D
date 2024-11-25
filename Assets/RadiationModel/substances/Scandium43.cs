using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium43 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium43";
        public override double halfLife { get; } = 14007.6d;
        public override double atomicWeight { get; } = 42.96115d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium43() }, { 1.0d, new BetaParticle(1, 193650.0) }, { 9e-06d, new GammaParticle(220400.0, 0.00563) }, { 0.225d, new GammaParticle(372900.0, 0.00332) }, { 2.1375e-05d, new GammaParticle(593300.0, 0.00209) }, { 1.8e-05d, new GammaParticle(1337900.0, 0.00093) }, { 8.4375e-05d, new GammaParticle(1558300.0, 0.0008) }, { 0.0001512d, new GammaParticle(1930700.0, 0.00064) }, { 1.7619999999999998d, new GammaParticle(511000.0, 0.00243) }, { 0.0004089645219096666d, new GammaParticle(358.0, 3.46325) }, { 0.0054082763605992025d, new GammaParticle(3688.0, 0.33618) }, { 0.010686181309225851d, new GammaParticle(3692.0, 0.33582) }, { 0.002085841714009327d, new GammaParticle(4013.0, 0.30896) }, { 0.002085841714009327d, new GammaParticle(4013.0, 0.30896) } } },

        };
    }
}
    