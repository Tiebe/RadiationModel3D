using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium83m : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium83m";
        public override double halfLife { get; } = 70.1d;
        public override double atomicWeight { get; } = 82.91936d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine83() }, { 1.0d, new BetaParticle(-1, 1951000.0) }, { 0.001751d, new GammaParticle(188900.0, 0.00656) }, { 0.003162d, new GammaParticle(231500.0, 0.00536) }, { 0.00025499999999999996d, new GammaParticle(322200.0, 0.00385) }, { 0.17d, new GammaParticle(356690.0, 0.00348) }, { 0.000952d, new GammaParticle(371660.0, 0.00334) }, { 0.0011899999999999999d, new GammaParticle(391500.0, 0.00317) }, { 0.000629d, new GammaParticle(442400.0, 0.0028) }, { 0.0020399999999999997d, new GammaParticle(510100.0, 0.00243) }, { 0.004505d, new GammaParticle(631200.0, 0.00196) }, { 0.1479d, new GammaParticle(673980.0, 0.00184) }, { 0.0008500000000000001d, new GammaParticle(698900.0, 0.00177) }, { 0.01224d, new GammaParticle(799150.0, 0.00155) }, { 0.00187d, new GammaParticle(812600.0, 0.00153) }, { 0.0020399999999999997d, new GammaParticle(884500.0, 0.0014) }, { 0.1564d, new GammaParticle(988050.0, 0.00125) }, { 0.011899999999999999d, new GammaParticle(997600.0, 0.00124) }, { 0.02108d, new GammaParticle(1020750.0, 0.00121) }, { 0.2057d, new GammaParticle(1030600.0, 0.0012) }, { 0.01547d, new GammaParticle(1053700.0, 0.00118) }, { 0.03468d, new GammaParticle(1063700.0, 0.00117) }, { 0.0068000000000000005d, new GammaParticle(1116300.0, 0.00111) }, { 0.0085d, new GammaParticle(1303300.0, 0.00095) }, { 0.0005099999999999999d, new GammaParticle(1549300.0, 0.0008) }, { 0.011899999999999999d, new GammaParticle(1558900.0, 0.0008) }, { 0.0017000000000000001d, new GammaParticle(1642800.0, 0.00075) }, { 0.019039999999999998d, new GammaParticle(1660100.0, 0.00075) }, { 0.0076500000000000005d, new GammaParticle(1694700.0, 0.00073) }, { 0.0028899999999999998d, new GammaParticle(1779000.0, 0.0007) }, { 0.000884d, new GammaParticle(2022500.0, 0.00061) }, { 0.10930999999999999d, new GammaParticle(2051500.0, 0.0006) }, { 0.000493d, new GammaParticle(2453200.0, 0.00051) }, { 0.000527d, new GammaParticle(2734700.0, 0.00045) }, { 0.000153d, new GammaParticle(2809900.0, 0.00044) }, { 0.00025499999999999996d, new GammaParticle(2944800.0, 0.00042) }, { 0.00042500000000000003d, new GammaParticle(3090700.0, 0.0004) }, { 1.6177126391360002e-05d, new GammaParticle(1535.0, 0.80771) }, { 0.00011943452514334677d, new GammaParticle(11879.0, 0.10437) }, { 0.00023052407863992816d, new GammaParticle(11925.0, 0.10397) }, { 5.467697086587929e-05d, new GammaParticle(13345.0, 0.09291) }, { 5.889803301672517e-05d, new GammaParticle(13377.0, 0.09268) }, { 4.221062150845881e-06d, new GammaParticle(13469.0, 0.09205) } } },

        };
    }
}
    