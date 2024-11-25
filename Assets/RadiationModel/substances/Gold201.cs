using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold201 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold201";
        public override double halfLife { get; } = 1560.0d;
        public override double atomicWeight { get; } = 200.97166d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury201() }, { 1.0d, new BetaParticle(-1, 630750.0) }, { 3.6e-07d, new GammaParticle(5895.0, 0.21032) }, { 0.00126d, new GammaParticle(30600.0, 0.04052) }, { 0.00135d, new GammaParticle(32190.0, 0.03852) }, { 0.0025d, new GammaParticle(135340.0, 0.00916) }, { 2.55e-06d, new GammaParticle(141100.0, 0.00879) }, { 0.000142d, new GammaParticle(165880.0, 0.00747) }, { 0.0096d, new GammaParticle(167430.0, 0.00741) }, { 0.0034999999999999996d, new GammaParticle(352420.0, 0.00352) }, { 0.0019d, new GammaParticle(358360.0, 0.00346) }, { 0.0027d, new GammaParticle(384600.0, 0.00322) }, { 0.0034999999999999996d, new GammaParticle(385100.0, 0.00322) }, { 0.00017999999999999998d, new GammaParticle(432320.0, 0.00287) }, { 0.0031d, new GammaParticle(438110.0, 0.00283) }, { 0.00098d, new GammaParticle(464390.0, 0.00267) }, { 0.0126d, new GammaParticle(517000.0, 0.0024) }, { 0.009300000000000001d, new GammaParticle(521000.0, 0.00238) }, { 0.0078000000000000005d, new GammaParticle(526900.0, 0.00235) }, { 0.0182d, new GammaParticle(542600.0, 0.00229) }, { 0.008d, new GammaParticle(552800.0, 0.00224) }, { 0.0116d, new GammaParticle(613200.0, 0.00202) }, { 0.0064d, new GammaParticle(645000.0, 0.00192) }, { 0.0042d, new GammaParticle(732300.0, 0.00169) }, { 0.040066932676985495d, new GammaParticle(11777.0, 0.10528) }, { 0.00751929417096443d, new GammaParticle(68894.0, 0.018) }, { 0.01274672685364372d, new GammaParticle(70820.0, 0.01751) }, { 0.004325925601540487d, new GammaParticle(80316.0, 0.01544) }, { 0.005593421802791849d, new GammaParticle(81285.0, 0.01525) }, { 0.0012674962012513627d, new GammaParticle(82477.0, 0.01503) } } },

        };
    }
}
    