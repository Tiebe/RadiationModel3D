using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon125 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon125";
        public override double halfLife { get; } = 60840.0d;
        public override double atomicWeight { get; } = 124.90639d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium125() }, { 1.0d, new BetaParticle(1, 911200.0) }, { 0.067788d, new GammaParticle(54968.0, 0.02256) }, { 0.0011836000000000001d, new GammaParticle(74875.0, 0.01656) }, { 0.0047882d, new GammaParticle(113551.0, 0.01092) }, { 0.0007101599999999999d, new GammaParticle(178485.0, 0.00695) }, { 0.5379999999999999d, new GammaParticle(188418.0, 0.00658) }, { 0.0007478200000000001d, new GammaParticle(210418.0, 0.00589) }, { 0.299666d, new GammaParticle(243378.0, 0.00509) }, { 0.0001345d, new GammaParticle(258360.0, 0.0048) }, { 0.00019906d, new GammaParticle(340220.0, 0.00364) }, { 0.00170546d, new GammaParticle(372081.0, 0.00333) }, { 0.00015602d, new GammaParticle(376130.0, 0.0033) }, { 0.00019906d, new GammaParticle(431020.0, 0.00288) }, { 0.0466984d, new GammaParticle(453796.0, 0.00273) }, { 0.00030666d, new GammaParticle(553690.0, 0.00224) }, { 0.0011836000000000001d, new GammaParticle(635382.0, 0.00195) }, { 0.0011298d, new GammaParticle(636110.0, 0.00195) }, { 0.0001345d, new GammaParticle(717900.0, 0.00173) }, { 0.00054876d, new GammaParticle(727096.0, 0.00171) }, { 7.531999999999999e-05d, new GammaParticle(764170.0, 0.00162) }, { 6.994e-05d, new GammaParticle(809180.0, 0.00153) }, { 0.00024209999999999998d, new GammaParticle(819020.0, 0.00151) }, { 0.011082799999999999d, new GammaParticle(846511.0, 0.00146) }, { 0.00016140000000000002d, new GammaParticle(894420.0, 0.00139) }, { 0.00577812d, new GammaParticle(901510.0, 0.00138) }, { 0.0015064d, new GammaParticle(937494.0, 0.00132) }, { 0.0010168199999999999d, new GammaParticle(992430.0, 0.00125) }, { 0.00160862d, new GammaParticle(1007431.0, 0.00123) }, { 0.00023672d, new GammaParticle(1020550.0, 0.00121) }, { 0.00017753999999999998d, new GammaParticle(1070850.0, 0.00116) }, { 0.00061332d, new GammaParticle(1075540.0, 0.00115) }, { 0.00065098d, new GammaParticle(1089860.0, 0.00114) }, { 2.5824e-05d, new GammaParticle(1108710.0, 0.00112) }, { 0.0029912800000000002d, new GammaParticle(1138230.0, 0.00109) }, { 0.0068325999999999994d, new GammaParticle(1180838.0, 0.00105) }, { 0.00066174d, new GammaParticle(1193230.0, 0.00104) }, { 3.9812e-05d, new GammaParticle(1199670.0, 0.00103) }, { 1.614e-05d, new GammaParticle(1254350.0, 0.00099) }, { 1.1298000000000001e-05d, new GammaParticle(1318910.0, 0.00094) }, { 5.918e-06d, new GammaParticle(1326000.0, 0.00094) }, { 1.5064e-05d, new GammaParticle(1381000.0, 0.0009) }, { 2.959e-05d, new GammaParticle(1385150.0, 0.0009) }, { 6.994e-05d, new GammaParticle(1442700.0, 0.00086) }, { 1.0759999999999999e-05d, new GammaParticle(1562400.0, 0.00079) }, { 0.006d, new GammaParticle(511000.0, 0.00243) }, { 0.1141726385777026d, new GammaParticle(4335.0, 0.28601) }, { 0.29766458935477325d, new GammaParticle(28318.0, 0.04378) }, { 0.5528688509561167d, new GammaParticle(28613.0, 0.04333) }, { 0.1592842397189073d, new GammaParticle(32395.0, 0.03827) }, { 0.19528247789538036d, new GammaParticle(32680.0, 0.03794) }, { 0.03599823817647305d, new GammaParticle(33040.0, 0.03753) } } },

        };
    }
}
    