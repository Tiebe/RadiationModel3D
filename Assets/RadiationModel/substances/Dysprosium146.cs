using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium146";
        public override double halfLife { get; } = 33.2d;
        public override double atomicWeight { get; } = 145.93284d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium146() }, { 1.0d, new BetaParticle(1, 6765500.0) }, { 0.00269d, new GammaParticle(74700.0, 0.0166) }, { 0.10615000000000001d, new GammaParticle(241100.0, 0.00514) }, { 0.013246d, new GammaParticle(268400.0, 0.00462) }, { 0.14733000000000002d, new GammaParticle(280200.0, 0.00442) }, { 0.01418d, new GammaParticle(322100.0, 0.00385) }, { 0.07676d, new GammaParticle(338100.0, 0.00367) }, { 0.04566d, new GammaParticle(354900.0, 0.00349) }, { 0.08359d, new GammaParticle(384600.0, 0.00322) }, { 1.0168000000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.087d, new GammaParticle(7118.0, 0.17418) }, { 0.125d, new GammaParticle(43743.0, 0.02834) }, { 0.225d, new GammaParticle(44481.0, 0.02787) }, { 0.07200000000000001d, new GammaParticle(50494.0, 0.02455) }, { 0.09d, new GammaParticle(51040.0, 0.02429) }, { 0.018600000000000002d, new GammaParticle(51699.0, 0.02398) } } },

        };
    }
}
    