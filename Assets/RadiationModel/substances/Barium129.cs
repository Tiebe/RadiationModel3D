using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium129 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium129";
        public override double halfLife { get; } = 8028.0d;
        public override double atomicWeight { get; } = 128.90868d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon129() }, { 1.0d, new BetaParticle(1, 1817535.0) }, { 5.93e-07d, new GammaParticle(6545.0, 0.18943) }, { 0.00054d, new GammaParticle(85100.0, 0.01457) }, { 0.055099999999999996d, new GammaParticle(129140.0, 0.0096) }, { 0.01d, new GammaParticle(135610.0, 0.00914) }, { 0.003d, new GammaParticle(202300.0, 0.00613) }, { 0.134d, new GammaParticle(214300.0, 0.00579) }, { 0.085d, new GammaParticle(220830.0, 0.00561) }, { 0.0044d, new GammaParticle(333900.0, 0.00371) }, { 0.0294d, new GammaParticle(554000.0, 0.00224) }, { 0.0011200000000000001d, new GammaParticle(944500.0, 0.00131) }, { 0.00017600000000000002d, new GammaParticle(1140300.0, 0.00109) }, { 0.011000000000000001d, new GammaParticle(1164400.0, 0.00106) }, { 0.0011799999999999998d, new GammaParticle(1276600.0, 0.00097) }, { 0.00055d, new GammaParticle(1368600.0, 0.00091) }, { 0.0005099999999999999d, new GammaParticle(1389300.0, 0.00089) }, { 0.000121d, new GammaParticle(1400100.0, 0.00089) }, { 0.00047d, new GammaParticle(1439800.0, 0.00086) }, { 0.00198d, new GammaParticle(1473600.0, 0.00084) }, { 0.00028000000000000003d, new GammaParticle(1558400.0, 0.0008) }, { 0.0033d, new GammaParticle(1610300.0, 0.00077) }, { 0.0008d, new GammaParticle(1693800.0, 0.00073) }, { 0.0008d, new GammaParticle(1694300.0, 0.00073) }, { 0.00086d, new GammaParticle(1701500.0, 0.00073) }, { 0.00086d, new GammaParticle(1744700.0, 0.00071) }, { 0.00021999999999999998d, new GammaParticle(1787500.0, 0.00069) }, { 0.0008d, new GammaParticle(1818800.0, 0.00068) }, { 0.006500000000000001d, new GammaParticle(1830300.0, 0.00068) }, { 1.1000000000000001e-05d, new GammaParticle(1856700.0, 0.00067) }, { 1.1000000000000001e-05d, new GammaParticle(1869000.0, 0.00066) }, { 0.000132d, new GammaParticle(1916400.0, 0.00065) }, { 0.00066d, new GammaParticle(1922600.0, 0.00064) }, { 0.0029d, new GammaParticle(1947500.0, 0.00064) }, { 0.0064d, new GammaParticle(1953800.0, 0.00063) }, { 0.3546d, new GammaParticle(511000.0, 0.00243) }, { 0.1d, new GammaParticle(4749.0, 0.26107) }, { 0.19d, new GammaParticle(30625.0, 0.04048) }, { 0.35100000000000003d, new GammaParticle(30973.0, 0.04003) }, { 0.1024d, new GammaParticle(35089.0, 0.03533) }, { 0.1274d, new GammaParticle(35414.0, 0.03501) }, { 0.025d, new GammaParticle(35818.0, 0.03462) } } },

        };
    }
}
    