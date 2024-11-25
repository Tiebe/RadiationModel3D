using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium84 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium84";
        public override double halfLife { get; } = 2835648.0d;
        public override double atomicWeight { get; } = 83.91438d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.961d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine84() }, { 1.0d, new BetaParticle(1, -988000.0) }, { 0.6890000000000001d, new GammaParticle(881604.1, 0.00141) }, { 0.0034899999999999996d, new GammaParticle(1016158.0, 0.00122) }, { 0.0074d, new GammaParticle(1897751.0, 0.00065) }, { 0.514d, new GammaParticle(511000.0, 0.00243) }, { 0.0164373629994d, new GammaParticle(1648.0, 0.75233) }, { 0.11458742672762828d, new GammaParticle(12596.0, 0.09843) }, { 0.22095531571081428d, new GammaParticle(12649.0, 0.09802) }, { 0.05294674269763578d, new GammaParticle(14169.0, 0.0875) }, { 0.05828377436155747d, new GammaParticle(14209.0, 0.08726) }, { 0.005337031663921687d, new GammaParticle(14313.0, 0.08662) } } },
            { 0.039d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium84() }, { 1.0d, new BetaParticle(-1, 445300.0) } } },

        };
    }
}
    