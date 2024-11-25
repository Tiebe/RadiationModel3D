using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium232";
        public override double halfLife { get; } = 114048.0d;
        public override double atomicWeight { get; } = 232.03859d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium232() }, { 1.0d, new BetaParticle(-1, 668800.0) }, { 0.0022752d, new GammaParticle(47640.0, 0.02603) }, { 0.001896d, new GammaParticle(80230.0, 0.01545) }, { 0.014599200000000001d, new GammaParticle(105400.0, 0.01176) }, { 0.0249324d, new GammaParticle(109000.0, 0.01137) }, { 9.48e-05d, new GammaParticle(132500.0, 0.00936) }, { 0.0054036d, new GammaParticle(139200.0, 0.00891) }, { 0.10428000000000001d, new GammaParticle(150059.0, 0.00826) }, { 0.0002844d, new GammaParticle(165000.0, 0.00751) }, { 9.48e-05d, new GammaParticle(174900.0, 0.00709) }, { 3.7919999999999996e-05d, new GammaParticle(176300.0, 0.00703) }, { 0.009290399999999999d, new GammaParticle(184101.0, 0.00673) }, { 4.74e-05d, new GammaParticle(219000.0, 0.00566) }, { 9.48e-05d, new GammaParticle(282200.0, 0.00439) }, { 0.0655068d, new GammaParticle(387884.0, 0.0032) }, { 0.0231312d, new GammaParticle(421932.0, 0.00294) }, { 0.0832344d, new GammaParticle(453655.0, 0.00273) }, { 0.0404796d, new GammaParticle(472390.0, 0.00262) }, { 0.0542256d, new GammaParticle(515607.0, 0.0024) }, { 0.0375408d, new GammaParticle(563197.0, 0.0022) }, { 0.0618096d, new GammaParticle(581398.0, 0.00213) }, { 0.0001896d, new GammaParticle(645000.0, 0.00192) }, { 0.0020856d, new GammaParticle(710100.0, 0.00175) }, { 0.0053088d, new GammaParticle(754800.0, 0.00164) }, { 0.000948d, new GammaParticle(814200.0, 0.00152) }, { 0.0733752d, new GammaParticle(819187.0, 0.00151) }, { 0.0188652d, new GammaParticle(863890.0, 0.00144) }, { 0.056406d, new GammaParticle(866760.0, 0.00143) }, { 0.196236d, new GammaParticle(894351.0, 0.00139) }, { 0.00011376000000000001d, new GammaParticle(911400.0, 0.00136) }, { 0.00042659999999999996d, new GammaParticle(923100.0, 0.00134) }, { 0.422808d, new GammaParticle(969315.0, 0.00128) }, { 0.00157368d, new GammaParticle(1003280.0, 0.00124) }, { 0.000128928d, new GammaParticle(1016400.0, 0.00122) }, { 0.00017064d, new GammaParticle(1051400.0, 0.00118) }, { 0.00069204d, new GammaParticle(1054500.0, 0.00118) }, { 0.00024648d, new GammaParticle(1085400.0, 0.00114) }, { 0.0020856d, new GammaParticle(1125480.0, 0.0011) }, { 9.48e-05d, new GammaParticle(1132700.0, 0.00109) }, { 0.00016115999999999998d, new GammaParticle(1164500.0, 0.00106) }, { 4.74e-05d, new GammaParticle(1171000.0, 0.00106) }, { 0.49d, new GammaParticle(16678.0, 0.07434) }, { 0.0103d, new GammaParticle(94657.0, 0.0131) }, { 0.0165d, new GammaParticle(98439.0, 0.0126) }, { 0.00594d, new GammaParticle(111238.0, 0.01115) }, { 0.008d, new GammaParticle(112645.0, 0.01101) }, { 0.00203d, new GammaParticle(114446.0, 0.01083) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    