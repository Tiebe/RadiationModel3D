using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton79m : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton79m";
        public override double halfLife { get; } = 50.0d;
        public override double atomicWeight { get; } = 78.92022d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton79() }, { 0.27699999999999997d, new GammaParticle(130010.0, 0.00954) }, { 0.016901752000000003d, new GammaParticle(1648.0, 0.75233) }, { 0.10851146748762704d, new GammaParticle(12596.0, 0.09843) }, { 0.20923923541771508d, new GammaParticle(12649.0, 0.09802) }, { 0.05013925971535059d, new GammaParticle(14169.0, 0.0875) }, { 0.05519329709465793d, new GammaParticle(14209.0, 0.08726) }, { 0.005054037379307339d, new GammaParticle(14313.0, 0.08662) } } },

        };
    }
}
    