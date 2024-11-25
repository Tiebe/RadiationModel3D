using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium69 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium69";
        public override double halfLife { get; } = 140580.0d;
        public override double atomicWeight { get; } = 68.92796d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc69() }, { 1.0d, new BetaParticle(1, 658600.0) }, { 0.000252d, new GammaParticle(200000.0, 0.0062) }, { 0.0036720000000000004d, new GammaParticle(234790.0, 0.00528) }, { 0.000252d, new GammaParticle(255400.0, 0.00485) }, { 0.000252d, new GammaParticle(298300.0, 0.00416) }, { 0.01548d, new GammaParticle(318630.0, 0.00389) }, { 0.000252d, new GammaParticle(380900.0, 0.00326) }, { 0.0007199999999999999d, new GammaParticle(419070.0, 0.00296) }, { 0.0027d, new GammaParticle(532660.0, 0.00233) }, { 0.006876d, new GammaParticle(553350.0, 0.00224) }, { 0.1332d, new GammaParticle(574110.0, 0.00216) }, { 0.0032400000000000003d, new GammaParticle(587400.0, 0.00211) }, { 0.002304d, new GammaParticle(762490.0, 0.00163) }, { 0.0034200000000000003d, new GammaParticle(788140.0, 0.00157) }, { 0.00035999999999999997d, new GammaParticle(816900.0, 0.00152) }, { 0.1188d, new GammaParticle(871980.0, 0.00142) }, { 0.000612d, new GammaParticle(912700.0, 0.00136) }, { 0.00039600000000000003d, new GammaParticle(951730.0, 0.0013) }, { 0.004284d, new GammaParticle(1052020.0, 0.00118) }, { 0.36d, new GammaParticle(1106770.0, 0.00112) }, { 0.00043200000000000004d, new GammaParticle(1151670.0, 0.00108) }, { 0.003924d, new GammaParticle(1207210.0, 0.00103) }, { 2.8800000000000002e-05d, new GammaParticle(1317100.0, 0.00094) }, { 0.045d, new GammaParticle(1336600.0, 0.00093) }, { 0.0032400000000000003d, new GammaParticle(1349890.0, 0.00092) }, { 0.00017999999999999998d, new GammaParticle(1404700.0, 0.00088) }, { 0.000468d, new GammaParticle(1449540.0, 0.00086) }, { 0.00010800000000000001d, new GammaParticle(1470300.0, 0.00084) }, { 0.000972d, new GammaParticle(1487960.0, 0.00083) }, { 0.002664d, new GammaParticle(1525840.0, 0.00081) }, { 0.002304d, new GammaParticle(1572850.0, 0.00079) }, { 0.00010800000000000001d, new GammaParticle(1615100.0, 0.00077) }, { 0.000612d, new GammaParticle(1723330.0, 0.00072) }, { 0.004788d, new GammaParticle(1891480.0, 0.00066) }, { 0.001512d, new GammaParticle(1924000.0, 0.00064) }, { 0.0054d, new GammaParticle(2023650.0, 0.00061) }, { 0.00035999999999999997d, new GammaParticle(2044900.0, 0.00061) }, { 0.47131d, new GammaParticle(511000.0, 0.00243) }, { 0.011721450973734155d, new GammaParticle(1127.0, 1.10013) }, { 0.10389290608305968d, new GammaParticle(9225.0, 0.1344) }, { 0.20189060645755866d, new GammaParticle(9252.0, 0.13401) }, { 0.044286936160206854d, new GammaParticle(10306.0, 0.1203) }, { 0.04455265777716809d, new GammaParticle(10313.0, 0.12022) }, { 0.0002657216169612411d, new GammaParticle(10365.0, 0.11962) } } },

        };
    }
}
    