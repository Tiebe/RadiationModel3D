using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium87m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium87m";
        public override double halfLife { get; } = 156.0d;
        public override double atomicWeight { get; } = 86.9207d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium87() }, { 1.0d, new BetaParticle(1, 4574200.0) }, { 0.3d, new GammaParticle(201000.0, 0.00617) }, { 0.006d, new GammaParticle(242400.0, 0.00511) }, { 0.018000000000000002d, new GammaParticle(269000.0, 0.00461) }, { 0.006d, new GammaParticle(322800.0, 0.00384) }, { 0.006d, new GammaParticle(461700.0, 0.00269) }, { 0.006d, new GammaParticle(466500.0, 0.00266) }, { 0.021d, new GammaParticle(470000.0, 0.00264) }, { 0.207d, new GammaParticle(470600.0, 0.00263) }, { 0.0285d, new GammaParticle(600000.0, 0.00207) }, { 0.09300000000000001d, new GammaParticle(616600.0, 0.00201) }, { 0.015d, new GammaParticle(797000.0, 0.00156) }, { 0.012d, new GammaParticle(801000.0, 0.00155) }, { 0.0216d, new GammaParticle(887000.0, 0.0014) }, { 0.0144d, new GammaParticle(983000.0, 0.00126) }, { 0.111d, new GammaParticle(1066800.0, 0.00116) }, { 0.021d, new GammaParticle(1083000.0, 0.00114) }, { 0.0108d, new GammaParticle(1168000.0, 0.00106) }, { 0.012d, new GammaParticle(1285000.0, 0.00096) }, { 0.006d, new GammaParticle(1295400.0, 0.00096) }, { 0.015d, new GammaParticle(1304600.0, 0.00095) }, { 0.006d, new GammaParticle(1360100.0, 0.00091) }, { 0.009000000000000001d, new GammaParticle(1559000.0, 0.0008) }, { 0.0072d, new GammaParticle(1683200.0, 0.00074) }, { 0.006d, new GammaParticle(1718700.0, 0.00072) }, { 0.006d, new GammaParticle(1858300.0, 0.00067) }, { 0.006d, new GammaParticle(1868400.0, 0.00066) }, { 0.099d, new GammaParticle(1884200.0, 0.00066) }, { 0.006d, new GammaParticle(2044400.0, 0.00061) }, { 0.011399999999999999d, new GammaParticle(2153300.0, 0.00058) }, { 0.006d, new GammaParticle(2397300.0, 0.00052) }, { 0.006d, new GammaParticle(2852300.0, 0.00043) }, { 0.006d, new GammaParticle(3246000.0, 0.00038) }, { 1.78d, new GammaParticle(511000.0, 0.00243) }, { 0.00212784819062d, new GammaParticle(2161.0, 0.57374) }, { 0.012013734605463552d, new GammaParticle(15691.0, 0.07902) }, { 0.022992793503279527d, new GammaParticle(15775.0, 0.0786) }, { 0.005858858718374278d, new GammaParticle(17736.0, 0.06991) }, { 0.006714252091256923d, new GammaParticle(17824.0, 0.06956) }, { 0.0008553933728826447d, new GammaParticle(17968.0, 0.069) } } },

        };
    }
}
    