using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium195 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium195";
        public override double halfLife { get; } = 8244.0d;
        public override double atomicWeight { get; } = 194.96598d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum195() }, { 1.0d, new BetaParticle(-1, 550800.0) }, { 0.013859999999999999d, new GammaParticle(30880.0, 0.04015) }, { 0.09999000000000001d, new GammaParticle(98830.0, 0.01255) }, { 0.013859999999999999d, new GammaParticle(129710.0, 0.00956) }, { 0.02475d, new GammaParticle(211300.0, 0.00587) }, { 0.32764631105844005d, new GammaParticle(11070.0, 0.112) }, { 0.16103920553559617d, new GammaParticle(65122.0, 0.01904) }, { 0.27528069322324134d, new GammaParticle(66832.0, 0.01855) }, { 0.09262467524196161d, new GammaParticle(75821.0, 0.01635) }, { 0.11911533236116263d, new GammaParticle(76725.0, 0.01616) }, { 0.02649065711920102d, new GammaParticle(77832.0, 0.01593) } } },

        };
    }
}
    