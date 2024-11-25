using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron52 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron52";
        public override double halfLife { get; } = 29790.0d;
        public override double atomicWeight { get; } = 51.94811d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium52() }, { 1.0d, new BetaParticle(1, 3543705.0) }, { 0.9917520000000001d, new GammaParticle(168688.0, 0.00735) }, { 0.0164331d, new GammaParticle(377748.0, 0.00328) }, { 0.0002883d, new GammaParticle(704600.0, 0.00176) }, { 0.00095139d, new GammaParticle(1039928.0, 0.00119) }, { 0.00045167d, new GammaParticle(1530709.0, 0.00081) }, { 0.0021142d, new GammaParticle(1727570.0, 0.00072) }, { 1.1098000000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.002953305531210136d, new GammaParticle(660.0, 1.87855) }, { 0.03787703457912723d, new GammaParticle(5888.0, 0.21057) }, { 0.07428326059840602d, new GammaParticle(5899.0, 0.21018) }, { 0.01524258411462677d, new GammaParticle(6512.0, 0.19039) }, { 0.01524258411462677d, new GammaParticle(6512.0, 0.19039) } } },

        };
    }
}
    