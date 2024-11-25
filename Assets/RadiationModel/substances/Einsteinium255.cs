using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium255";
        public override double halfLife { get; } = 3438720.0d;
        public override double atomicWeight { get; } = 255.09027d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.92d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium255() }, { 1.0d, new BetaParticle(-1, 144500.0) } } },
            { 0.08d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Berkelium251() }, { 1.0d, new AlphaParticle(7458002.09) } } },
            { 4.1e-05d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    