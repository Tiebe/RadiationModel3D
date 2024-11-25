using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium160";
        public override double halfLife { get; } = 288.0d;
        public override double atomicWeight { get; } = 159.93756d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium160() }, { 1.0d, new BetaParticle(1, 3950500.0) }, { 0.013300000000000001d, new GammaParticle(34180.0, 0.03627) }, { 0.0017000000000000001d, new GammaParticle(41460.0, 0.0299) }, { 0.031200000000000002d, new GammaParticle(42020.0, 0.02951) }, { 0.002d, new GammaParticle(62050.0, 0.01998) }, { 0.0039000000000000003d, new GammaParticle(94290.0, 0.01315) }, { 0.012d, new GammaParticle(98240.0, 0.01262) }, { 0.009000000000000001d, new GammaParticle(99460.0, 0.01247) }, { 0.0084d, new GammaParticle(116440.0, 0.01065) }, { 0.06d, new GammaParticle(132230.0, 0.00938) }, { 0.095d, new GammaParticle(140350.0, 0.00883) }, { 0.0073d, new GammaParticle(155760.0, 0.00796) }, { 0.43d, new GammaParticle(173740.0, 0.00714) }, { 0.055999999999999994d, new GammaParticle(174400.0, 0.00711) }, { 0.205d, new GammaParticle(215780.0, 0.00575) }, { 0.0043d, new GammaParticle(278000.0, 0.00446) }, { 0.014499999999999999d, new GammaParticle(320000.0, 0.00387) }, { 0.024d, new GammaParticle(327600.0, 0.00378) }, { 0.004699999999999999d, new GammaParticle(354600.0, 0.0035) }, { 0.0032d, new GammaParticle(356900.0, 0.00347) }, { 0.0045000000000000005d, new GammaParticle(366200.0, 0.00339) }, { 0.043d, new GammaParticle(373000.0, 0.00332) }, { 0.0128d, new GammaParticle(386300.0, 0.00321) }, { 0.0222d, new GammaParticle(389450.0, 0.00318) }, { 0.0069d, new GammaParticle(395160.0, 0.00314) }, { 0.0051d, new GammaParticle(429000.0, 0.00289) }, { 0.006d, new GammaParticle(465200.0, 0.00267) }, { 0.0077d, new GammaParticle(563100.0, 0.0022) }, { 0.0128d, new GammaParticle(582120.0, 0.00213) }, { 0.0064d, new GammaParticle(588700.0, 0.00211) }, { 0.033134000000000004d, new GammaParticle(511000.0, 0.00243) }, { 0.36814399440835d, new GammaParticle(8215.0, 0.15092) }, { 0.2569963888870557d, new GammaParticle(49773.0, 0.02491) }, { 0.4537365623005927d, new GammaParticle(50742.0, 0.02443) }, { 0.14835140171615202d, new GammaParticle(57612.0, 0.02152) }, { 0.18692276616235154d, new GammaParticle(58257.0, 0.02128) }, { 0.03857136444619953d, new GammaParticle(59034.0, 0.021) } } },

        };
    }
}
    