using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium53 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium53";
        public override double halfLife { get; } = 92.58d;
        public override double atomicWeight { get; } = 52.94433d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium53() }, { 1.0d, new BetaParticle(-1, 1717810.0) }, { 0.001792d, new GammaParticle(247000.0, 0.00502) }, { 0.007616d, new GammaParticle(282700.0, 0.00439) }, { 0.0038528d, new GammaParticle(442700.0, 0.0028) }, { 0.001792d, new GammaParticle(531000.0, 0.00233) }, { 0.0038528d, new GammaParticle(563600.0, 0.0022) }, { 0.8959999999999999d, new GammaParticle(1006000.0, 0.00123) }, { 0.100352d, new GammaParticle(1289100.0, 0.00096) } } },

        };
    }
}
    