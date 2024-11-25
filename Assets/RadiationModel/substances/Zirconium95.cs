using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium95";
        public override double halfLife { get; } = 5532364.8d;
        public override double atomicWeight { get; } = 94.90804d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium95() }, { 1.0d, new BetaParticle(-1, 563200.0) }, { 0.0027d, new GammaParticle(235690.0, 0.00526) }, { 0.44270000000000004d, new GammaParticle(724192.0, 0.00171) }, { 0.5438000000000001d, new GammaParticle(756725.0, 0.00164) }, { 0.000312146300861d, new GammaParticle(2299.0, 0.5393) }, { 0.0015848212874552394d, new GammaParticle(16521.0, 0.07505) }, { 0.0030267786238640944d, new GammaParticle(16615.0, 0.07462) }, { 0.0007831699675484052d, new GammaParticle(18694.0, 0.06632) }, { 0.000900645462680666d, new GammaParticle(18795.0, 0.06597) }, { 0.00011747549513226078d, new GammaParticle(18951.0, 0.06542) } } },

        };
    }
}
    