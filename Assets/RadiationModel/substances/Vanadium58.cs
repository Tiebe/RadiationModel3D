using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium58 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium58";
        public override double halfLife { get; } = 0.191d;
        public override double atomicWeight { get; } = 57.9566d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium58() }, { 1.0d, new BetaParticle(-1, 5780900.0) }, { 0.62d, new GammaParticle(879700.0, 0.00141) }, { 0.08d, new GammaParticle(1041200.0, 0.00119) }, { 0.28d, new GammaParticle(1056400.0, 0.00117) }, { 0.05d, new GammaParticle(1501400.0, 0.00083) }, { 0.05d, new GammaParticle(1570600.0, 0.00079) }, { 0.13d, new GammaParticle(2216800.0, 0.00056) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    