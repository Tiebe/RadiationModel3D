using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper61 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper61";
        public override double halfLife { get; } = 12020.4d;
        public override double atomicWeight { get; } = 60.93346d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt61() }, { 1.0d, new BetaParticle(1, 457050.0) }, { 0.04d, new GammaParticle(67412.0, 0.01839) }, { 0.0001d, new GammaParticle(117500.0, 0.01055) }, { 4.9e-05d, new GammaParticle(190790.0, 0.0065) }, { 0.00013d, new GammaParticle(215550.0, 0.00575) }, { 0.00026d, new GammaParticle(276688.0, 0.00448) }, { 0.127d, new GammaParticle(282956.0, 0.00438) }, { 0.021400000000000002d, new GammaParticle(373050.0, 0.00332) }, { 3.7000000000000005e-05d, new GammaParticle(443500.0, 0.0028) }, { 0.0037d, new GammaParticle(529169.0, 0.00234) }, { 6e-05d, new GammaParticle(544800.0, 0.00228) }, { 0.011699999999999999d, new GammaParticle(588605.0, 0.00211) }, { 0.00043999999999999996d, new GammaParticle(625605.0, 0.00198) }, { 0.00062d, new GammaParticle(629900.0, 0.00197) }, { 0.10400000000000001d, new GammaParticle(656008.0, 0.00189) }, { 0.000111d, new GammaParticle(701100.0, 0.00177) }, { 0.0034999999999999996d, new GammaParticle(816692.0, 0.00152) }, { 0.00021999999999999998d, new GammaParticle(820890.0, 0.00151) }, { 0.0024d, new GammaParticle(841211.0, 0.00147) }, { 0.0008699999999999999d, new GammaParticle(902294.0, 0.00137) }, { 0.0109d, new GammaParticle(908631.0, 0.00136) }, { 2.8e-05d, new GammaParticle(947400.0, 0.00131) }, { 9e-06d, new GammaParticle(1014800.0, 0.00122) }, { 0.00055d, new GammaParticle(1032162.0, 0.0012) }, { 0.0005d, new GammaParticle(1064896.0, 0.00116) }, { 0.00042d, new GammaParticle(1073465.0, 0.00115) }, { 5.999999999999999e-06d, new GammaParticle(1089110.0, 0.00114) }, { 0.0027d, new GammaParticle(1099560.0, 0.00113) }, { 0.00043999999999999996d, new GammaParticle(1117822.0, 0.00111) }, { 0.00091d, new GammaParticle(1132351.0, 0.00109) }, { 0.036000000000000004d, new GammaParticle(1185234.0, 0.00105) }, { 0.00046d, new GammaParticle(1446492.0, 0.00086) }, { 0.00033d, new GammaParticle(1542204.0, 0.0008) }, { 0.00024d, new GammaParticle(1609625.0, 0.00077) }, { 0.0005099999999999999d, new GammaParticle(1662000.0, 0.00075) }, { 0.0005d, new GammaParticle(1729473.0, 0.00072) }, { 1.7e-05d, new GammaParticle(1840700.0, 0.00067) }, { 3.8e-05d, new GammaParticle(1997730.0, 0.00062) }, { 9.499999999999999e-05d, new GammaParticle(2120000.0, 0.00058) }, { 0.00041d, new GammaParticle(2123432.0, 0.00058) }, { 1.22866d, new GammaParticle(511000.0, 0.00243) }, { 0.0044d, new GammaParticle(874.0, 1.41858) }, { 0.044000000000000004d, new GammaParticle(7461.0, 0.16618) }, { 0.085d, new GammaParticle(7478.0, 0.1658) }, { 0.0177d, new GammaParticle(8296.0, 0.14945) }, { 0.0177d, new GammaParticle(8296.0, 0.14945) } } },

        };
    }
}
    