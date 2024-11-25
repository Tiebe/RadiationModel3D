using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium63 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium63";
        public override double halfLife { get; } = 0.0196d;
        public override double atomicWeight { get; } = 62.97666d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium63() }, { 1.0d, new BetaParticle(-1, 7220000.0) }, { 0.04d, new GammaParticle(83100.0, 0.01492) }, { 0.15d, new GammaParticle(120300.0, 0.01031) }, { 0.04d, new GammaParticle(414000.0, 0.00299) } } },
            { 0.29d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium63() }, { 1.0d, new BetaParticle(-1, 7220000.0) }, { 0.04d, new GammaParticle(83100.0, 0.01492) }, { 0.15d, new GammaParticle(120300.0, 0.01031) }, { 0.04d, new GammaParticle(414000.0, 0.00299) } } },

        };
    }
}
    