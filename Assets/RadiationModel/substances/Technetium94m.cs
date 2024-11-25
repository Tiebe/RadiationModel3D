using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium94m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium94m";
        public override double halfLife { get; } = 3120.0d;
        public override double atomicWeight { get; } = 93.90973d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium94() }, { 1.0d, new BetaParticle(1, 1143550.0) }, { 0.9420000000000001d, new GammaParticle(871050.0, 0.00142) }, { 0.0079128d, new GammaParticle(875100.0, 0.00142) }, { 0.022136999999999997d, new GammaParticle(993190.0, 0.00125) }, { 0.0021666d, new GammaParticle(998200.0, 0.00124) }, { 0.0015072d, new GammaParticle(1005800.0, 0.00123) }, { 0.0027318d, new GammaParticle(1022200.0, 0.00121) }, { 0.00044274d, new GammaParticle(1037200.0, 0.0012) }, { 0.00042389999999999995d, new GammaParticle(1101300.0, 0.00113) }, { 0.007536d, new GammaParticle(1196400.0, 0.00104) }, { 0.0021666d, new GammaParticle(1264900.0, 0.00098) }, { 0.001884d, new GammaParticle(1357400.0, 0.00091) }, { 0.00058404d, new GammaParticle(1499000.0, 0.00083) }, { 0.045216000000000006d, new GammaParticle(1522100.0, 0.00081) }, { 0.00034854000000000005d, new GammaParticle(1670100.0, 0.00074) }, { 0.0015072d, new GammaParticle(1757900.0, 0.00071) }, { 0.0001884d, new GammaParticle(1769900.0, 0.0007) }, { 0.002355d, new GammaParticle(1864000.0, 0.00067) }, { 0.057462d, new GammaParticle(1868680.0, 0.00066) }, { 0.0008477999999999999d, new GammaParticle(1928800.0, 0.00064) }, { 0.0002355d, new GammaParticle(2027500.0, 0.00061) }, { 0.0008477999999999999d, new GammaParticle(2067400.0, 0.0006) }, { 0.00052752d, new GammaParticle(2257500.0, 0.00055) }, { 0.00049926d, new GammaParticle(2292200.0, 0.00054) }, { 0.00471d, new GammaParticle(2393200.0, 0.00052) }, { 0.0031086000000000004d, new GammaParticle(2529800.0, 0.00049) }, { 0.0012246d, new GammaParticle(2577200.0, 0.00048) }, { 0.00034854000000000005d, new GammaParticle(2641600.0, 0.00047) }, { 0.0006594d, new GammaParticle(2664100.0, 0.00047) }, { 0.0352308d, new GammaParticle(2740100.0, 0.00045) }, { 0.00020724d, new GammaParticle(2869900.0, 0.00043) }, { 0.0007536d, new GammaParticle(3021600.0, 0.00041) }, { 0.00011304d, new GammaParticle(3065600.0, 0.0004) }, { 0.00016014d, new GammaParticle(3085800.0, 0.0004) }, { 0.013847400000000001d, new GammaParticle(3129100.0, 0.0004) }, { 4.71e-05d, new GammaParticle(3400800.0, 0.00036) }, { 4.71e-05d, new GammaParticle(3447000.0, 0.00036) }, { 0.0005652d, new GammaParticle(3512500.0, 0.00035) }, { 6.594e-05d, new GammaParticle(3640600.0, 0.00034) }, { 0.000471d, new GammaParticle(3793100.0, 0.00033) }, { 0.00015072d, new GammaParticle(3892700.0, 0.00032) }, { 6.594e-05d, new GammaParticle(4136200.0, 0.0003) }, { 1.4030532d, new GammaParticle(511000.0, 0.00243) }, { 0.011399999999999999d, new GammaParticle(2440.0, 0.50813) }, { 0.0574d, new GammaParticle(17374.0, 0.07136) }, { 0.1094d, new GammaParticle(17479.0, 0.07093) }, { 0.0287d, new GammaParticle(19681.0, 0.063) }, { 0.0331d, new GammaParticle(19794.0, 0.06264) }, { 0.00442d, new GammaParticle(19963.0, 0.06211) } } },
            { 0.001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium94() } } },

        };
    }
}
    