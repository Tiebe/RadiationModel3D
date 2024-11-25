using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium56 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium56";
        public override double halfLife { get; } = 356.4d;
        public override double atomicWeight { get; } = 55.94065d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese56() }, { 1.0d, new BetaParticle(-1, 813285.0) }, { 0.446d, new GammaParticle(26000.0, 0.04769) }, { 0.953d, new GammaParticle(83000.0, 0.01494) }, { 0.0039301886506400005d, new GammaParticle(660.0, 1.87855) }, { 0.050547928627865654d, new GammaParticle(5888.0, 0.21057) }, { 0.09913302339255865d, new GammaParticle(5899.0, 0.21018) }, { 0.020341641379575663d, new GammaParticle(6512.0, 0.19039) }, { 0.020341641379575663d, new GammaParticle(6512.0, 0.19039) } } },

        };
    }
}
    