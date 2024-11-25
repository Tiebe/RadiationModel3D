using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium107";
        public override double halfLife { get; } = 23400.0d;
        public override double atomicWeight { get; } = 106.90661d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium107() }, { 1.0d, new BetaParticle(1, 691200.0) }, { 4.727e-05d, new GammaParticle(32460.0, 0.0382) }, { 0.046780999999999996d, new GammaParticle(93124.0, 0.01331) }, { 1.3529e-05d, new GammaParticle(98200.0, 0.01263) }, { 2.608e-05d, new GammaParticle(300900.0, 0.00412) }, { 0.00030644d, new GammaParticle(324810.0, 0.00382) }, { 3.423e-06d, new GammaParticle(356400.0, 0.00348) }, { 2.445e-06d, new GammaParticle(364000.0, 0.00341) }, { 0.00029340000000000003d, new GammaParticle(423150.0, 0.00293) }, { 2.608e-06d, new GammaParticle(436600.0, 0.00284) }, { 6.52e-06d, new GammaParticle(461700.0, 0.00269) }, { 4.4825000000000005e-05d, new GammaParticle(526500.0, 0.00235) }, { 8.965e-06d, new GammaParticle(549900.0, 0.00225) }, { 7.5795e-05d, new GammaParticle(597270.0, 0.00208) }, { 3.5045e-05d, new GammaParticle(624910.0, 0.00198) }, { 1.793e-06d, new GammaParticle(648400.0, 0.00191) }, { 3.586e-05d, new GammaParticle(719930.0, 0.00172) }, { 1.63e-05d, new GammaParticle(786450.0, 0.00158) }, { 0.00064874d, new GammaParticle(796462.0, 0.00156) }, { 1.956e-05d, new GammaParticle(799920.0, 0.00155) }, { 2.0374999999999997e-05d, new GammaParticle(818230.0, 0.00152) }, { 0.0016300000000000002d, new GammaParticle(828934.0, 0.0015) }, { 8.965e-07d, new GammaParticle(856500.0, 0.00145) }, { 9.698500000000001e-05d, new GammaParticle(898170.0, 0.00138) }, { 7.334999999999999e-07d, new GammaParticle(934000.0, 0.00133) }, { 1.304e-05d, new GammaParticle(949800.0, 0.00131) }, { 1.956e-06d, new GammaParticle(1050000.0, 0.00118) }, { 1.956e-05d, new GammaParticle(1097500.0, 0.00113) }, { 7.172e-05d, new GammaParticle(1129900.0, 0.0011) }, { 2.445e-07d, new GammaParticle(1143000.0, 0.00108) }, { 4.075e-06d, new GammaParticle(1165700.0, 0.00106) }, { 1.63e-08d, new GammaParticle(1223000.0, 0.00101) }, { 4.727e-06d, new GammaParticle(1232600.0, 0.00101) }, { 4.89e-07d, new GammaParticle(1259000.0, 0.00098) }, { 1.3855000000000001e-06d, new GammaParticle(1264500.0, 0.00098) }, { 1.9559999999999998e-07d, new GammaParticle(1294000.0, 0.00096) }, { 5.705e-07d, new GammaParticle(1297000.0, 0.00096) }, { 8.15e-07d, new GammaParticle(1325800.0, 0.00094) }, { 0.004d, new GammaParticle(511000.0, 0.00243) }, { 0.10377319404132121d, new GammaParticle(3218.0, 0.38528) }, { 0.30923936980097516d, new GammaParticle(21990.0, 0.05638) }, { 0.582920583979218d, new GammaParticle(22163.0, 0.05594) }, { 0.16148551122512014d, new GammaParticle(25030.0, 0.04953) }, { 0.18958399017829103d, new GammaParticle(25211.0, 0.04918) }, { 0.028098478953170903d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    