using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium145m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium145m";
        public override double halfLife { get; } = 2.4d;
        public override double atomicWeight { get; } = 144.94737d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium145() }, { 1.0d, new BetaParticle(1, 8690000.0) }, { 0.0225d, new GammaParticle(66300.0, 0.0187) }, { 0.0075d, new GammaParticle(249200.0, 0.00498) }, { 0.0375d, new GammaParticle(309100.0, 0.00401) }, { 0.1425d, new GammaParticle(312900.0, 0.00396) }, { 0.018000000000000002d, new GammaParticle(315100.0, 0.00393) }, { 0.012d, new GammaParticle(316600.0, 0.00392) }, { 0.135d, new GammaParticle(334100.0, 0.00371) }, { 0.15d, new GammaParticle(339800.0, 0.00365) }, { 0.0225d, new GammaParticle(387600.0, 0.0032) }, { 0.1275d, new GammaParticle(401800.0, 0.00309) }, { 0.018000000000000002d, new GammaParticle(498300.0, 0.00249) }, { 0.03d, new GammaParticle(543200.0, 0.00228) }, { 0.0225d, new GammaParticle(563300.0, 0.0022) }, { 0.0225d, new GammaParticle(622100.0, 0.00199) }, { 0.03d, new GammaParticle(700500.0, 0.00177) }, { 0.0075d, new GammaParticle(852000.0, 0.00146) }, { 1.21d, new GammaParticle(511000.0, 0.00243) }, { 0.034d, new GammaParticle(7384.0, 0.16791) }, { 0.046d, new GammaParticle(45207.0, 0.02743) }, { 0.083d, new GammaParticle(45998.0, 0.02695) }, { 0.027000000000000003d, new GammaParticle(52220.0, 0.02374) }, { 0.033d, new GammaParticle(52791.0, 0.02349) }, { 0.0069d, new GammaParticle(53478.0, 0.02318) } } },

        };
    }
}
    