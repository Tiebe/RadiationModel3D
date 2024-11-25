using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium48 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium48";
        public override double halfLife { get; } = 77616.0d;
        public override double atomicWeight { get; } = 47.95403d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium48() }, { 1.0d, new BetaParticle(1, 2835975.0) }, { 0.96d, new GammaParticle(112310.0, 0.01104) }, { 1.0d, new GammaParticle(308240.0, 0.00402) }, { 0.0003d, new GammaParticle(420500.0, 0.00295) }, { 0.0294d, new GammaParticle(511000.0, 0.00243) }, { 0.00548566706268d, new GammaParticle(536.0, 2.31314) }, { 0.06673840262903365d, new GammaParticle(4945.0, 0.25073) }, { 0.13129727056666074d, new GammaParticle(4952.0, 0.25037) }, { 0.02641795880430563d, new GammaParticle(5444.0, 0.22774) }, { 0.02641795880430563d, new GammaParticle(5444.0, 0.22774) } } },

        };
    }
}
    