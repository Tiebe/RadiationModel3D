using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium170";
        public override double halfLife { get; } = 0.96d;
        public override double atomicWeight { get; } = 169.94985d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium170() }, { 1.0d, new BetaParticle(-1, 3500000.0) }, { 0.092d, new GammaParticle(71450.0, 0.01735) }, { 0.151d, new GammaParticle(165840.0, 0.00748) }, { 0.10400000000000001d, new GammaParticle(687720.0, 0.0018) }, { 0.74d, new GammaParticle(789930.0, 0.00157) }, { 0.059000000000000004d, new GammaParticle(853700.0, 0.00145) }, { 0.09699999999999999d, new GammaParticle(920200.0, 0.00135) }, { 0.027999999999999997d, new GammaParticle(992100.0, 0.00125) }, { 0.08d, new GammaParticle(1104500.0, 0.00112) }, { 0.16d, new GammaParticle(1169310.0, 0.00106) }, { 0.15139180187824d, new GammaParticle(7384.0, 0.16791) }, { 0.06699742346499388d, new GammaParticle(45207.0, 0.02743) }, { 0.11972377316832357d, new GammaParticle(45998.0, 0.02695) }, { 0.03844085587831949d, new GammaParticle(52220.0, 0.02374) }, { 0.04843547840668255d, new GammaParticle(52791.0, 0.02349) }, { 0.009994622528363067d, new GammaParticle(53478.0, 0.02318) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    