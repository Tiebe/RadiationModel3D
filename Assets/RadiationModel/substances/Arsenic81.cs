using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic81 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic81";
        public override double halfLife { get; } = 33.3d;
        public override double atomicWeight { get; } = 80.92213d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium81() }, { 1.0d, new BetaParticle(-1, 1927850.0) }, { 0.0028399999999999996d, new GammaParticle(156000.0, 0.00795) }, { 0.0086d, new GammaParticle(388100.0, 0.00319) }, { 0.2d, new GammaParticle(467700.0, 0.00265) }, { 0.085d, new GammaParticle(491200.0, 0.00252) }, { 0.013999999999999999d, new GammaParticle(521100.0, 0.00238) }, { 0.00172d, new GammaParticle(756000.0, 0.00164) }, { 0.00328d, new GammaParticle(836100.0, 0.00148) }, { 0.0013800000000000002d, new GammaParticle(874900.0, 0.00142) }, { 0.0010199999999999999d, new GammaParticle(915000.0, 0.00136) }, { 0.0034000000000000002d, new GammaParticle(938900.0, 0.00132) }, { 0.0036d, new GammaParticle(949700.0, 0.00131) }, { 0.00998d, new GammaParticle(1406000.0, 0.00088) }, { 0.00376d, new GammaParticle(1561900.0, 0.00079) }, { 0.00132d, new GammaParticle(1661800.0, 0.00075) }, { 0.0011200000000000001d, new GammaParticle(1688400.0, 0.00073) }, { 0.0007000000000000001d, new GammaParticle(1842100.0, 0.00067) }, { 0.00114d, new GammaParticle(1864500.0, 0.00066) }, { 8e-05d, new GammaParticle(1882000.0, 0.00066) }, { 0.0022400000000000002d, new GammaParticle(2029600.0, 0.00061) }, { 0.00068d, new GammaParticle(2079300.0, 0.0006) }, { 0.00366d, new GammaParticle(2102200.0, 0.00059) }, { 0.0005600000000000001d, new GammaParticle(2145800.0, 0.00058) }, { 0.0027400000000000002d, new GammaParticle(2301800.0, 0.00054) }, { 0.00066d, new GammaParticle(2332300.0, 0.00053) }, { 0.00078d, new GammaParticle(2340800.0, 0.00053) }, { 0.00172d, new GammaParticle(2569500.0, 0.00048) }, { 0.00154d, new GammaParticle(2659600.0, 0.00047) }, { 0.00096d, new GammaParticle(2733300.0, 0.00045) }, { 0.0028399999999999996d, new GammaParticle(2832400.0, 0.00044) }, { 0.00035999999999999997d, new GammaParticle(3118200.0, 0.0004) }, { 1.030414e-05d, new GammaParticle(1426.0, 0.86945) }, { 7.867324631264596e-05d, new GammaParticle(11183.0, 0.11087) }, { 0.00015252665047042643d, new GammaParticle(11223.0, 0.11047) }, { 3.559278850305583e-05d, new GammaParticle(12546.0, 0.09882) }, { 3.759310321692757e-05d, new GammaParticle(12571.0, 0.09863) }, { 2.0003147138717376e-06d, new GammaParticle(12652.0, 0.098) } } },

        };
    }
}
    