using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium175";
        public override double halfLife { get; } = 361584.0d;
        public override double atomicWeight { get; } = 174.94128d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium175() }, { 1.0d, new BetaParticle(-1, 235069.99999) }, { 0.038661d, new GammaParticle(113805.0, 0.01089) }, { 0.00235385d, new GammaParticle(137658.0, 0.00901) }, { 0.006719650000000001d, new GammaParticle(144863.0, 0.00856) }, { 0.00172265d, new GammaParticle(251474.0, 0.00493) }, { 0.061279d, new GammaParticle(282522.0, 0.00439) }, { 0.1315d, new GammaParticle(396329.0, 0.00313) }, { 0.021277072887606798d, new GammaParticle(8810.0, 0.14073) }, { 0.021950907673624124d, new GammaParticle(52965.0, 0.02341) }, { 0.03855094428103991d, new GammaParticle(54070.0, 0.02293) }, { 0.012684328139229406d, new GammaParticle(61387.0, 0.0202) }, { 0.016032990767985967d, new GammaParticle(62084.0, 0.01997) }, { 0.003348662628756563d, new GammaParticle(62927.0, 0.0197) } } },

        };
    }
}
    