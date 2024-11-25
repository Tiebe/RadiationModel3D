using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium56 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium56";
        public override double halfLife { get; } = 0.216d;
        public override double atomicWeight { get; } = 55.95042d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium56() }, { 1.0d, new BetaParticle(-1, 4552550.0) }, { 0.26d, new GammaParticle(668400.0, 0.00185) }, { 0.01d, new GammaParticle(824100.0, 0.0015) }, { 0.3d, new GammaParticle(1006100.0, 0.00123) }, { 0.01d, new GammaParticle(1317900.0, 0.00094) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    