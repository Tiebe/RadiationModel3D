using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc62 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc62";
        public override double halfLife { get; } = 33094.8d;
        public override double atomicWeight { get; } = 61.93433d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel62() }, { 1.0d, new BetaParticle(1, 2789150.0) }, { 0.2548d, new GammaParticle(40850.0, 0.03035) }, { 0.0001092d, new GammaParticle(202670.0, 0.00612) }, { 0.02522d, new GammaParticle(243360.0, 0.00509) }, { 0.01898d, new GammaParticle(246950.0, 0.00502) }, { 0.01352d, new GammaParticle(260430.0, 0.00476) }, { 0.002886d, new GammaParticle(304880.0, 0.00407) }, { 0.004497999999999999d, new GammaParticle(349600.0, 0.00355) }, { 0.0001742d, new GammaParticle(385310.0, 0.00322) }, { 0.02236d, new GammaParticle(394030.0, 0.00315) }, { 0.00015859999999999998d, new GammaParticle(489170.0, 0.00253) }, { 0.1482d, new GammaParticle(507600.0, 0.00244) }, { 0.1534d, new GammaParticle(548350.0, 0.00226) }, { 0.26d, new GammaParticle(596560.0, 0.00208) }, { 7.8e-06d, new GammaParticle(627800.0, 0.00197) }, { 0.0025480000000000004d, new GammaParticle(637410.0, 0.00195) }, { 0.000143d, new GammaParticle(644820.0, 0.00192) }, { 1.3e-05d, new GammaParticle(657500.0, 0.00189) }, { 4.4200000000000004e-05d, new GammaParticle(671840.0, 0.00185) }, { 2.288e-05d, new GammaParticle(731230.0, 0.0017) }, { 8.840000000000001e-05d, new GammaParticle(792030.0, 0.00157) }, { 2.9900000000000002e-05d, new GammaParticle(827590.0, 0.0015) }, { 0.0001456d, new GammaParticle(881400.0, 0.00141) }, { 0.0001534d, new GammaParticle(915440.0, 0.00135) }, { 0.0003458d, new GammaParticle(1141910.0, 0.00109) }, { 3.9e-05d, new GammaParticle(1186200.0, 0.00105) }, { 1.508e-05d, new GammaParticle(1221500.0, 0.00102) }, { 1.3e-05d, new GammaParticle(1321300.0, 0.00094) }, { 0.000117d, new GammaParticle(1389100.0, 0.00089) }, { 0.00027560000000000003d, new GammaParticle(1429700.0, 0.00087) }, { 5.199999999999999e-06d, new GammaParticle(1485100.0, 0.00083) }, { 5.72e-05d, new GammaParticle(1525900.0, 0.00081) }, { 0.16399999999999998d, new GammaParticle(511000.0, 0.00243) }, { 0.013636266682761283d, new GammaParticle(952.0, 1.30236) }, { 0.12960119640267156d, new GammaParticle(8028.0, 0.15444) }, { 0.2524862583336676d, new GammaParticle(8048.0, 0.15406) }, { 0.05314836495382479d, new GammaParticle(8940.0, 0.13868) }, { 0.05314836495382479d, new GammaParticle(8940.0, 0.13868) } } },

        };
    }
}
    