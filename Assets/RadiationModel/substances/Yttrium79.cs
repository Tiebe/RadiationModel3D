using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium79 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium79";
        public override double halfLife { get; } = 14.8d;
        public override double atomicWeight { get; } = 78.93795d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium79() }, { 1.0d, new BetaParticle(1, 6501400.0) }, { 0.14d, new GammaParticle(152500.0, 0.00813) }, { 1.022d, new GammaParticle(177400.0, 0.00699) }, { 0.252d, new GammaParticle(1106000.0, 0.00112) }, { 1.98d, new GammaParticle(511000.0, 0.00243) }, { 0.0009299999999999999d, new GammaParticle(1890.0, 0.656) }, { 0.0059d, new GammaParticle(14098.0, 0.08794) }, { 0.011000000000000001d, new GammaParticle(14165.0, 0.08753) }, { 0.0028000000000000004d, new GammaParticle(15898.0, 0.07799) }, { 0.0031d, new GammaParticle(15955.0, 0.07771) }, { 0.00035999999999999997d, new GammaParticle(16085.0, 0.07708) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    