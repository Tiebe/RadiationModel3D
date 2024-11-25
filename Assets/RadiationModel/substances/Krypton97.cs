using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton97 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton97";
        public override double halfLife { get; } = 0.063d;
        public override double atomicWeight { get; } = 96.94909d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium97() }, { 1.0d, new BetaParticle(-1, 5549550.0) } } },
            { 0.067d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium97() }, { 1.0d, new BetaParticle(-1, 5549550.0) } } },

        };
    }
}
    