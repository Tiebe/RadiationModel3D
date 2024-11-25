using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium111";
        public override double halfLife { get; } = 0.29d;
        public override double atomicWeight { get; } = 110.9259d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium111() }, { 1.0d, new BetaParticle(-1, 3880000.0) }, { 0.01011d, new GammaParticle(63000.0, 0.01968) }, { 0.0002359d, new GammaParticle(76000.0, 0.01631) }, { 0.045158d, new GammaParticle(103900.0, 0.01193) }, { 0.31341d, new GammaParticle(150200.0, 0.00825) }, { 0.01011d, new GammaParticle(166900.0, 0.00743) }, { 0.00674d, new GammaParticle(172600.0, 0.00718) }, { 0.024264d, new GammaParticle(205600.0, 0.00603) }, { 0.00337d, new GammaParticle(212800.0, 0.00583) }, { 0.019545999999999997d, new GammaParticle(218500.0, 0.00567) }, { 0.12469d, new GammaParticle(279700.0, 0.00443) }, { 0.337d, new GammaParticle(368800.0, 0.00336) }, { 0.009436d, new GammaParticle(392100.0, 0.00316) }, { 0.00674d, new GammaParticle(413800.0, 0.003) }, { 0.07077d, new GammaParticle(542800.0, 0.00228) }, { 0.025949d, new GammaParticle(571000.0, 0.00217) }, { 0.005729d, new GammaParticle(616500.0, 0.00201) }, { 0.004044d, new GammaParticle(674300.0, 0.00184) }, { 0.009772999999999999d, new GammaParticle(713200.0, 0.00174) }, { 0.005055d, new GammaParticle(898200.0, 0.00138) }, { 0.032014999999999995d, new GammaParticle(1026300.0, 0.00121) }, { 0.05055d, new GammaParticle(1435200.0, 0.00086) }, { 0.0033151557438d, new GammaParticle(2737.0, 0.45299) }, { 0.013761247683205009d, new GammaParticle(19150.0, 0.06474) }, { 0.026112424446309315d, new GammaParticle(19279.0, 0.06431) }, { 0.007017354518490258d, new GammaParticle(21736.0, 0.05704) }, { 0.00815416595048568d, new GammaParticle(21875.0, 0.05668) }, { 0.0011368114319954216d, new GammaParticle(22072.0, 0.05617) } } },
            { 0.0085d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium111() }, { 1.0d, new BetaParticle(-1, 3880000.0) }, { 0.01011d, new GammaParticle(63000.0, 0.01968) }, { 0.0002359d, new GammaParticle(76000.0, 0.01631) }, { 0.045158d, new GammaParticle(103900.0, 0.01193) }, { 0.31341d, new GammaParticle(150200.0, 0.00825) }, { 0.01011d, new GammaParticle(166900.0, 0.00743) }, { 0.00674d, new GammaParticle(172600.0, 0.00718) }, { 0.024264d, new GammaParticle(205600.0, 0.00603) }, { 0.00337d, new GammaParticle(212800.0, 0.00583) }, { 0.019545999999999997d, new GammaParticle(218500.0, 0.00567) }, { 0.12469d, new GammaParticle(279700.0, 0.00443) }, { 0.337d, new GammaParticle(368800.0, 0.00336) }, { 0.009436d, new GammaParticle(392100.0, 0.00316) }, { 0.00674d, new GammaParticle(413800.0, 0.003) }, { 0.07077d, new GammaParticle(542800.0, 0.00228) }, { 0.025949d, new GammaParticle(571000.0, 0.00217) }, { 0.005729d, new GammaParticle(616500.0, 0.00201) }, { 0.004044d, new GammaParticle(674300.0, 0.00184) }, { 0.009772999999999999d, new GammaParticle(713200.0, 0.00174) }, { 0.005055d, new GammaParticle(898200.0, 0.00138) }, { 0.032014999999999995d, new GammaParticle(1026300.0, 0.00121) }, { 0.05055d, new GammaParticle(1435200.0, 0.00086) }, { 0.0033151557438d, new GammaParticle(2737.0, 0.45299) }, { 0.013761247683205009d, new GammaParticle(19150.0, 0.06474) }, { 0.026112424446309315d, new GammaParticle(19279.0, 0.06431) }, { 0.007017354518490258d, new GammaParticle(21736.0, 0.05704) }, { 0.00815416595048568d, new GammaParticle(21875.0, 0.05668) }, { 0.0011368114319954216d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    