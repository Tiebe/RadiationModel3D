using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton69 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton69";
        public override double halfLife { get; } = 0.028d;
        public override double atomicWeight { get; } = 68.9655d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium69() }, { 1.0d, new BetaParticle(1, 12147350.0) }, { 1.088d, new GammaParticle(511000.0, 0.00243) }, { 1.7928705551999998e-05d, new GammaParticle(1535.0, 0.80771) }, { 0.000131610930214934d, new GammaParticle(11879.0, 0.10437) }, { 0.00025402611506453193d, new GammaParticle(11925.0, 0.10397) }, { 6.0251313331353616e-05d, new GammaParticle(13345.0, 0.09291) }, { 6.490271472053411e-05d, new GammaParticle(13377.0, 0.09268) }, { 4.651401389180499e-06d, new GammaParticle(13469.0, 0.09205) } } },
            { 0.99d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium68() }, { 1.0d, new BetaParticle(1, 476771751.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    