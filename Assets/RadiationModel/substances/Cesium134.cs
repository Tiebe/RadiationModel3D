using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium134";
        public override double halfLife { get; } = 65171363.52273d;
        public override double atomicWeight { get; } = 133.90672d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.999997d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium134() }, { 1.0d, new BetaParticle(-1, 1029417.5) }, { 1.0999967e-05d, new GammaParticle(232600.0, 0.00533) }, { 0.00027d, new GammaParticle(242738.0, 0.00511) }, { 0.00016199999999999998d, new GammaParticle(326589.0, 0.0038) }, { 0.01477d, new GammaParticle(475365.0, 0.00261) }, { 0.08338d, new GammaParticle(563246.0, 0.0022) }, { 0.15373d, new GammaParticle(569331.0, 0.00218) }, { 0.9762000000000001d, new GammaParticle(604721.0, 0.00205) }, { 0.8545999999999999d, new GammaParticle(795864.0, 0.00156) }, { 0.08688000000000001d, new GammaParticle(801953.0, 0.00155) }, { 0.009899999999999999d, new GammaParticle(1038610.0, 0.00119) }, { 0.0179d, new GammaParticle(1167968.0, 0.00106) }, { 0.03017d, new GammaParticle(1365185.0, 0.00091) }, { 0.00105d, new GammaParticle(4966.0, 0.24967) }, { 0.0023799999999999997d, new GammaParticle(31816.0, 0.03897) }, { 0.00439d, new GammaParticle(32193.0, 0.03851) }, { 0.0012920000000000002d, new GammaParticle(36482.0, 0.03399) }, { 0.001618d, new GammaParticle(36827.0, 0.03367) }, { 0.00032599999999999996d, new GammaParticle(37255.0, 0.03328) } } },
            { 2.9999999999999997e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon134() }, { 2.9999999999999997e-06d, new GammaParticle(847000.0, 0.00146) }, { 2.5740813564e-07d, new GammaParticle(4540.0, 0.27309) }, { 6.348918804504769e-07d, new GammaParticle(29458.0, 0.04209) }, { 1.1761613198415652e-06d, new GammaParticle(29778.0, 0.04164) }, { 3.409644657831377e-07d, new GammaParticle(33726.0, 0.03676) }, { 4.214320797079582e-07d, new GammaParticle(34030.0, 0.03643) }, { 8.04676139248205e-08d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    