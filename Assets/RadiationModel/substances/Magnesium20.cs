using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium20 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium20";
        public override double halfLife { get; } = 0.0904d;
        public override double atomicWeight { get; } = 20.01876d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium20() }, { 1.0d, new BetaParticle(1, 5313600.0) }, { 1.9340000000000002d, new GammaParticle(511000.0, 0.00243) } } },
            { 0.303d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon19() }, { 1.0d, new BetaParticle(1, 473609876.736) }, { 1.0d, new ProtonParticle() }, { 0.0239d, new GammaParticle(238000.0, 0.00521) }, { 0.0458d, new GammaParticle(275000.0, 0.00451) }, { 0.0022d, new GammaParticle(1233000.0, 0.00101) }, { 0.0007000000000000001d, new GammaParticle(1261000.0, 0.00098) }, { 0.0003d, new GammaParticle(1269000.0, 0.00098) }, { 0.0124d, new GammaParticle(1298000.0, 0.00096) } } },

        };
    }
}
    