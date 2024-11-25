using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth196 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth196";
        public override double halfLife { get; } = 308.0d;
        public override double atomicWeight { get; } = 195.98067d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium196() }, { 1.0d, new BetaParticle(1, 4744000.0) }, { 0.0048d, new GammaParticle(288700.0, 0.00429) }, { 0.011200000000000002d, new GammaParticle(306900.0, 0.00404) }, { 0.008d, new GammaParticle(375500.0, 0.0033) }, { 0.062400000000000004d, new GammaParticle(400900.0, 0.00309) }, { 0.0288d, new GammaParticle(471500.0, 0.00263) }, { 0.0368d, new GammaParticle(473700.0, 0.00262) }, { 0.0208d, new GammaParticle(519100.0, 0.00239) }, { 0.0032d, new GammaParticle(550400.0, 0.00225) }, { 0.0208d, new GammaParticle(620800.0, 0.002) }, { 0.027200000000000002d, new GammaParticle(637800.0, 0.00194) }, { 0.0304d, new GammaParticle(665400.0, 0.00186) }, { 0.016d, new GammaParticle(674600.0, 0.00184) }, { 0.3552d, new GammaParticle(689300.0, 0.0018) }, { 0.0144d, new GammaParticle(732500.0, 0.00169) }, { 0.022400000000000003d, new GammaParticle(753400.0, 0.00165) }, { 0.0128d, new GammaParticle(753400.0, 0.00165) }, { 0.09119999999999999d, new GammaParticle(776600.0, 0.0016) }, { 0.0384d, new GammaParticle(846700.0, 0.00146) }, { 0.0192d, new GammaParticle(868800.0, 0.00143) }, { 0.0064d, new GammaParticle(916800.0, 0.00135) }, { 0.064d, new GammaParticle(942400.0, 0.00132) }, { 0.008d, new GammaParticle(947600.0, 0.00131) }, { 0.0192d, new GammaParticle(1011100.0, 0.00123) }, { 0.011200000000000002d, new GammaParticle(1030900.0, 0.0012) }, { 0.8687999999999999d, new GammaParticle(1049400.0, 0.00118) }, { 0.011200000000000002d, new GammaParticle(1075000.0, 0.00115) }, { 0.0688d, new GammaParticle(1449700.0, 0.00086) }, { 0.0144d, new GammaParticle(1896300.0, 0.00065) }, { 0.0032d, new GammaParticle(2060900.0, 0.0006) }, { 1.0728d, new GammaParticle(511000.0, 0.00243) }, { 0.15770551737308d, new GammaParticle(12522.0, 0.09901) }, { 0.11778973200467645d, new GammaParticle(72805.0, 0.01703) }, { 0.19796593614231336d, new GammaParticle(74970.0, 0.01654) }, { 0.06766192888864068d, new GammaParticle(84986.0, 0.01459) }, { 0.08809583141301017d, new GammaParticle(86022.0, 0.01441) }, { 0.020433902524369486d, new GammaParticle(87301.0, 0.0142) } } },
            { 1.15e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium192() }, { 1.0d, new AlphaParticle(6458002.09) } } },

        };
    }
}
    