using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium118";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 117.90636d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin118() }, { 1.0d, new BetaParticle(-1, 2212400.0) }, { 0.006999999999999999d, new GammaParticle(528000.0, 0.00235) }, { 0.0019500000000000001d, new GammaParticle(813000.0, 0.00153) }, { 0.00035000000000000005d, new GammaParticle(827000.0, 0.0015) }, { 0.001d, new GammaParticle(1097000.0, 0.00113) }, { 0.0043d, new GammaParticle(1173400.0, 0.00106) }, { 0.05d, new GammaParticle(1229700.0, 0.00101) }, { 0.0013d, new GammaParticle(1908200.0, 0.00065) }, { 0.00105d, new GammaParticle(2043200.0, 0.00061) } } },

        };
    }
}
    