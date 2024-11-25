using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium242";
        public override double halfLife { get; } = 57636.0d;
        public override double atomicWeight { get; } = 242.05955d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.83d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium242() }, { 1.0d, new BetaParticle(-1, 332150.00001) }, { 0.00035999999999999997d, new GammaParticle(42129.0, 0.02943) }, { 0.16336908d, new GammaParticle(18579.0, 0.06673) } } },
            { 0.17d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium242() }, { 0.00015d, new GammaParticle(44542.0, 0.02784) }, { 0.11102499267400001d, new GammaParticle(17604.0, 0.07043) }, { 0.03565238998439918d, new GammaParticle(99533.0, 0.01246) }, { 0.05643880003862463d, new GammaParticle(103741.0, 0.01195) }, { 0.02071539018335279d, new GammaParticle(117130.0, 0.01059) }, { 0.027903630576976212d, new GammaParticle(118619.0, 0.01045) }, { 0.007188240393623419d, new GammaParticle(120544.0, 0.01029) } } },
            { 1e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium238() }, { 1.0d, new AlphaParticle(6610402.09) } } },

        };
    }
}
    