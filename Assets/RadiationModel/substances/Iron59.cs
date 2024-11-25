using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron59 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron59";
        public override double halfLife { get; } = 3843936.0d;
        public override double atomicWeight { get; } = 58.93487d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt59() }, { 1.0d, new BetaParticle(-1, 782400.0) }, { 0.0102d, new GammaParticle(142651.0, 0.00869) }, { 1.1000000000000001e-05d, new GammaParticle(189000.0, 0.00656) }, { 0.0308d, new GammaParticle(192343.0, 0.00645) }, { 0.0027d, new GammaParticle(334800.0, 0.0037) }, { 0.00017999999999999998d, new GammaParticle(382000.0, 0.00325) }, { 0.565d, new GammaParticle(1099245.0, 0.00113) }, { 0.43200000000000005d, new GammaParticle(1291590.0, 0.00096) }, { 0.0005899999999999999d, new GammaParticle(1481700.0, 0.00084) }, { 5.982698579760001e-06d, new GammaParticle(800.0, 1.5498) }, { 6.325247647625393e-05d, new GammaParticle(6915.0, 0.1793) }, { 0.000123636584199089d, new GammaParticle(6930.0, 0.17891) }, { 2.5641179124657053e-05d, new GammaParticle(7677.0, 0.1615) }, { 2.5641179124657053e-05d, new GammaParticle(7677.0, 0.1615) } } },

        };
    }
}
    