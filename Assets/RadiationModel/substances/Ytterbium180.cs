using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium180 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium180";
        public override double halfLife { get; } = 144.0d;
        public override double atomicWeight { get; } = 179.95199d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium180() }, { 1.0d, new BetaParticle(-1, 980000.0) }, { 0.0567d, new GammaParticle(102800.0, 0.01206) }, { 0.0504d, new GammaParticle(108800.0, 0.0114) }, { 0.1008d, new GammaParticle(119700.0, 0.01036) }, { 0.63d, new GammaParticle(172900.0, 0.00717) }, { 0.09449999999999999d, new GammaParticle(266400.0, 0.00465) }, { 0.2961d, new GammaParticle(339400.0, 0.00365) }, { 0.4473d, new GammaParticle(375200.0, 0.0033) }, { 0.2583d, new GammaParticle(385800.0, 0.00321) }, { 0.3276d, new GammaParticle(419600.0, 0.00295) }, { 0.0441d, new GammaParticle(439300.0, 0.00282) }, { 0.0378d, new GammaParticle(442300.0, 0.0028) }, { 0.1953d, new GammaParticle(547900.0, 0.00226) }, { 0.10728858246624d, new GammaParticle(8810.0, 0.14073) }, { 0.08141550150868967d, new GammaParticle(52965.0, 0.02341) }, { 0.14298472340830642d, new GammaParticle(54070.0, 0.02293) }, { 0.04704593323022466d, new GammaParticle(61387.0, 0.0202) }, { 0.05946605960300397d, new GammaParticle(62084.0, 0.01997) }, { 0.01242012637277931d, new GammaParticle(62927.0, 0.0197) } } },

        };
    }
}
    