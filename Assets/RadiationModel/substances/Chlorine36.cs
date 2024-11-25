using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine36 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine36";
        public override double halfLife { get; } = 9508101796144.57d;
        public override double atomicWeight { get; } = 35.96831d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.981d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Argon36() }, { 1.0d, new BetaParticle(-1, 354766.0) } } },
            { 0.019d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus36() }, { 1.0d, new BetaParticle(1, -4635505.0) }, { 0.00028000000000000003d, new GammaParticle(511000.0, 0.00243) }, { 3.0153899175e-05d, new GammaParticle(185.0, 6.70185) }, { 0.0004333570106902879d, new GammaParticle(2306.0, 0.53766) }, { 0.0008576232152984125d, new GammaParticle(2308.0, 0.53719) }, { 8.004077401129942e-05d, new GammaParticle(2466.0, 0.50277) }, { 8.004077401129942e-05d, new GammaParticle(2466.0, 0.50277) } } },

        };
    }
}
    