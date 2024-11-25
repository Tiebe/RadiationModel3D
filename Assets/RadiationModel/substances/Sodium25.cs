using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium25 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium25";
        public override double halfLife { get; } = 59.1d;
        public override double atomicWeight { get; } = 24.98995d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium25() }, { 1.0d, new BetaParticle(-1, 1917490.0) }, { 0.12675d, new GammaParticle(389710.0, 0.00318) }, { 0.13d, new GammaParticle(585028.0, 0.00212) }, { 0.00104d, new GammaParticle(836841.0, 0.00148) }, { 0.1495d, new GammaParticle(974742.0, 0.00127) }, { 0.001664d, new GammaParticle(989865.0, 0.00125) }, { 0.002314d, new GammaParticle(1379543.0, 0.0009) }, { 0.09477000000000001d, new GammaParticle(1611716.0, 0.00077) }, { 0.0014663999999999999d, new GammaParticle(1964501.0, 0.00063) }, { 0.0009347d, new GammaParticle(2216267.0, 0.00056) }, { 0.000494d, new GammaParticle(2801312.0, 0.00044) }, { 8.563022986206e-09d, new GammaParticle(46.0, 26.95309) }, { 2.7136135795854744e-07d, new GammaParticle(1254.0, 0.98871) }, { 1.3652189918894522e-07d, new GammaParticle(1254.0, 0.98871) } } },

        };
    }
}
    