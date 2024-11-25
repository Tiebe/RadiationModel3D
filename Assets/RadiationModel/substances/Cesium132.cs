using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium132";
        public override double halfLife { get; } = 559872.0d;
        public override double atomicWeight { get; } = 131.90644d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9813d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine132() }, { 1.0d, new BetaParticle(1, -724350.0) }, { 0.000683d, new GammaParticle(363340.0, 0.00341) }, { 0.0073d, new GammaParticle(505790.0, 0.00245) }, { 0.0095d, new GammaParticle(630190.0, 0.00197) }, { 0.9759d, new GammaParticle(667714.0, 0.00186) }, { 2.1e-05d, new GammaParticle(687740.0, 0.0018) }, { 0.0007199999999999999d, new GammaParticle(772600.0, 0.0016) }, { 0.0047599999999999995d, new GammaParticle(1136000.0, 0.00109) }, { 0.00055d, new GammaParticle(1297910.0, 0.00096) }, { 0.00586d, new GammaParticle(1317918.0, 0.00094) }, { 0.0007000000000000001d, new GammaParticle(1985625.0, 0.00062) }, { 0.00814d, new GammaParticle(511000.0, 0.00243) }, { 0.08423520182769727d, new GammaParticle(4540.0, 0.27309) }, { 0.21103256139536067d, new GammaParticle(29458.0, 0.04209) }, { 0.39094583437451036d, new GammaParticle(29778.0, 0.04164) }, { 0.11333363486702992d, new GammaParticle(33726.0, 0.03676) }, { 0.140080372695649d, new GammaParticle(34030.0, 0.03643) }, { 0.026746737828619062d, new GammaParticle(34414.0, 0.03603) } } },
            { 0.0187d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium132() }, { 1.0d, new BetaParticle(-1, 641100.0) }, { 0.015798239999999998d, new GammaParticle(464466.0, 0.00267) }, { 0.002233208d, new GammaParticle(567160.0, 0.00219) }, { 2.9256e-05d, new GammaParticle(663130.0, 0.00187) }, { 0.001287264d, new GammaParticle(1031660.0, 0.0012) }, { 1.98130283818368e-05d, new GammaParticle(4966.0, 0.24967) }, { 4.419648164298973e-05d, new GammaParticle(31816.0, 0.03897) }, { 8.142314230469736e-05d, new GammaParticle(32193.0, 0.03851) }, { 2.395000338363651e-05d, new GammaParticle(36482.0, 0.03399) }, { 2.9985404236312912e-05d, new GammaParticle(36827.0, 0.03367) }, { 6.0354008526764e-06d, new GammaParticle(37255.0, 0.03328) } } },

        };
    }
}
    