using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium57 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium57";
        public override double halfLife { get; } = 0.32d;
        public override double atomicWeight { get; } = 56.95229d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium57() }, { 1.0d, new BetaParticle(-1, 4042500.0) }, { 0.02d, new GammaParticle(249300.0, 0.00497) }, { 0.52d, new GammaParticle(267800.0, 0.00463) }, { 0.03d, new GammaParticle(425300.0, 0.00292) }, { 0.2d, new GammaParticle(692400.0, 0.00179) }, { 0.01d, new GammaParticle(892500.0, 0.00139) }, { 0.07d, new GammaParticle(941700.0, 0.00132) }, { 0.02d, new GammaParticle(1289600.0, 0.00096) }, { 0.02d, new GammaParticle(1314300.0, 0.00094) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    