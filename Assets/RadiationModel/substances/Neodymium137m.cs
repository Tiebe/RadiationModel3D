using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium137m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium137m";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 136.91512d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium137() }, { 0.34506d, new GammaParticle(108400.0, 0.01144) }, { 0.5751d, new GammaParticle(177500.0, 0.00699) }, { 0.639d, new GammaParticle(233700.0, 0.00531) }, { 0.20448d, new GammaParticle(286100.0, 0.00433) }, { 0.11855834788896001d, new GammaParticle(5870.0, 0.21122) }, { 0.17702546695763297d, new GammaParticle(36848.0, 0.03365) }, { 0.32239203598184835d, new GammaParticle(37362.0, 0.03318) }, { 0.09900942063048428d, new GammaParticle(42380.0, 0.02926) }, { 0.12445484173251872d, new GammaParticle(42810.0, 0.02896) }, { 0.025445421102034457d, new GammaParticle(43335.0, 0.02861) } } },

        };
    }
}
    