using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium132";
        public override double halfLife { get; } = 12636.0d;
        public override double atomicWeight { get; } = 131.91147d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium132() }, { 1.0d, new BetaParticle(1, 2982950.0) }, { 8.514e-05d, new GammaParticle(20000.0, 0.06199) }, { 0.0021671999999999998d, new GammaParticle(26650.0, 0.04652) }, { 0.0035604d, new GammaParticle(34710.0, 0.03572) }, { 0.000774d, new GammaParticle(47730.0, 0.02598) }, { 0.0018576d, new GammaParticle(61490.0, 0.02016) }, { 0.0010062d, new GammaParticle(62270.0, 0.01991) }, { 0.0001548d, new GammaParticle(76200.0, 0.01627) }, { 0.0001161d, new GammaParticle(78200.0, 0.01585) }, { 0.0001161d, new GammaParticle(81530.0, 0.01521) }, { 0.0001161d, new GammaParticle(83430.0, 0.01486) }, { 0.0001161d, new GammaParticle(88200.0, 0.01406) }, { 0.0002322d, new GammaParticle(112350.0, 0.01104) }, { 0.000774d, new GammaParticle(123660.0, 0.01003) }, { 0.0009288d, new GammaParticle(127720.0, 0.00971) }, { 0.00035603999999999996d, new GammaParticle(135260.0, 0.00917) }, { 0.000774d, new GammaParticle(137660.0, 0.00901) }, { 0.0049536d, new GammaParticle(142180.0, 0.00872) }, { 0.10526400000000001d, new GammaParticle(155370.0, 0.00798) }, { 0.001935d, new GammaParticle(176840.0, 0.00701) }, { 0.774d, new GammaParticle(182110.0, 0.00681) }, { 0.026703d, new GammaParticle(190040.0, 0.00652) }, { 0.00133128d, new GammaParticle(199780.0, 0.00621) }, { 0.0013932d, new GammaParticle(205800.0, 0.00602) }, { 0.049536d, new GammaParticle(216830.0, 0.00572) }, { 0.0017802d, new GammaParticle(224680.0, 0.00552) }, { 0.0018576d, new GammaParticle(246900.0, 0.00502) }, { 0.022446d, new GammaParticle(251460.0, 0.00493) }, { 0.0047214d, new GammaParticle(268130.0, 0.00462) }, { 0.01935d, new GammaParticle(279120.0, 0.00444) }, { 0.020898d, new GammaParticle(303120.0, 0.00409) }, { 0.0012384d, new GammaParticle(324820.0, 0.00382) }, { 0.02322d, new GammaParticle(329640.0, 0.00376) }, { 0.011300399999999999d, new GammaParticle(368510.0, 0.00336) }, { 0.001935d, new GammaParticle(389830.0, 0.00318) }, { 0.01161d, new GammaParticle(424670.0, 0.00292) }, { 0.009675d, new GammaParticle(431490.0, 0.00287) }, { 0.022446d, new GammaParticle(451440.0, 0.00275) }, { 0.0041796d, new GammaParticle(523780.0, 0.00237) }, { 0.010062d, new GammaParticle(576380.0, 0.00215) }, { 0.001548d, new GammaParticle(606730.0, 0.00204) }, { 0.0006966d, new GammaParticle(731680.0, 0.00169) }, { 0.001161d, new GammaParticle(820340.0, 0.00151) }, { 0.11199999999999999d, new GammaParticle(5185.0, 0.23912) }, { 0.23399999999999999d, new GammaParticle(33034.0, 0.03753) }, { 0.43d, new GammaParticle(33442.0, 0.03707) }, { 0.1281d, new GammaParticle(37908.0, 0.03271) }, { 0.1605d, new GammaParticle(38273.0, 0.03239) }, { 0.032400000000000005d, new GammaParticle(38725.0, 0.03202) } } },

        };
    }
}
    