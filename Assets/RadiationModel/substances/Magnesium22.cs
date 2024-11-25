using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium22 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium22";
        public override double halfLife { get; } = 3.8755d;
        public override double atomicWeight { get; } = 21.99957d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon22() }, { 1.0d, new BetaParticle(1, 3812363.0) }, { 0.58342492d, new GammaParticle(73900.0, 0.01678) }, { 0.9997d, new GammaParticle(583040.0, 0.00213) }, { 0.053983800000000005d, new GammaParticle(1280500.0, 0.00097) }, { 0.000149955d, new GammaParticle(1353800.0, 0.00092) }, { 0.00031990400000000003d, new GammaParticle(1936800.0, 0.00064) }, { 1.9982d, new GammaParticle(511000.0, 0.00243) }, { 3.924694309861176e-05d, new GammaParticle(1041.0, 1.19101) }, { 1.9737287684291853e-05d, new GammaParticle(1041.0, 1.19101) } } },

        };
    }
}
    