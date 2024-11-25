using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium122";
        public override double halfLife { get; } = 21.18d;
        public override double atomicWeight { get; } = 121.91611d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine122() }, { 1.0d, new BetaParticle(1, 3969500.0) }, { 0.475d, new GammaParticle(331100.0, 0.00374) }, { 0.0028499999999999997d, new GammaParticle(371000.0, 0.00334) }, { 0.0014249999999999998d, new GammaParticle(385600.0, 0.00322) }, { 0.009975000000000001d, new GammaParticle(497100.0, 0.00249) }, { 0.0418d, new GammaParticle(512000.0, 0.00242) }, { 0.0028499999999999997d, new GammaParticle(648200.0, 0.00191) }, { 0.0028499999999999997d, new GammaParticle(666500.0, 0.00186) }, { 0.0003325d, new GammaParticle(760000.0, 0.00163) }, { 0.030875d, new GammaParticle(817900.0, 0.00152) }, { 0.0006175d, new GammaParticle(822100.0, 0.00151) }, { 0.00095d, new GammaParticle(827900.0, 0.0015) }, { 0.0019d, new GammaParticle(840500.0, 0.00148) }, { 0.019d, new GammaParticle(843000.0, 0.00147) }, { 0.000665d, new GammaParticle(851100.0, 0.00146) }, { 0.0017100000000000001d, new GammaParticle(873100.0, 0.00142) }, { 0.008075d, new GammaParticle(882900.0, 0.0014) }, { 0.0014249999999999998d, new GammaParticle(945400.0, 0.00131) }, { 0.005699999999999999d, new GammaParticle(1035900.0, 0.0012) }, { 0.0025174999999999998d, new GammaParticle(1038900.0, 0.00119) }, { 0.00095d, new GammaParticle(1148400.0, 0.00108) }, { 0.0037524999999999998d, new GammaParticle(1163600.0, 0.00107) }, { 0.0007124999999999999d, new GammaParticle(1177000.0, 0.00105) }, { 0.0002375d, new GammaParticle(1194000.0, 0.00104) }, { 0.0017100000000000001d, new GammaParticle(1222500.0, 0.00101) }, { 0.0016150000000000001d, new GammaParticle(1236800.0, 0.001) }, { 0.006935d, new GammaParticle(1385200.0, 0.0009) }, { 0.0006175d, new GammaParticle(1421500.0, 0.00087) }, { 0.0016150000000000001d, new GammaParticle(1428200.0, 0.00087) }, { 0.00018999999999999998d, new GammaParticle(1441300.0, 0.00086) }, { 0.001045d, new GammaParticle(1457200.0, 0.00085) }, { 0.0009025d, new GammaParticle(1460000.0, 0.00085) }, { 0.0024224999999999997d, new GammaParticle(1486600.0, 0.00083) }, { 0.006175000000000001d, new GammaParticle(1495500.0, 0.00083) }, { 0.0012825d, new GammaParticle(1515000.0, 0.00082) }, { 0.0009975000000000001d, new GammaParticle(1550900.0, 0.0008) }, { 0.005225d, new GammaParticle(1734400.0, 0.00071) }, { 0.0037524999999999998d, new GammaParticle(1799000.0, 0.00069) }, { 0.002185d, new GammaParticle(1811100.0, 0.00068) }, { 0.0019d, new GammaParticle(1836100.0, 0.00068) }, { 0.002185d, new GammaParticle(1889800.0, 0.00066) }, { 0.0044174999999999996d, new GammaParticle(1933000.0, 0.00064) }, { 0.0037524999999999998d, new GammaParticle(2011300.0, 0.00062) }, { 0.0019d, new GammaParticle(2162500.0, 0.00057) }, { 0.005225d, new GammaParticle(2199100.0, 0.00056) }, { 1.9025999999999998d, new GammaParticle(511000.0, 0.00243) }, { 0.0052298370397385d, new GammaParticle(4540.0, 0.27309) }, { 0.013070097919549783d, new GammaParticle(29458.0, 0.04209) }, { 0.024212852759447543d, new GammaParticle(29778.0, 0.04164) }, { 0.007019209241911552d, new GammaParticle(33726.0, 0.03676) }, { 0.008675742623002677d, new GammaParticle(34030.0, 0.03643) }, { 0.0016565333810911259d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    