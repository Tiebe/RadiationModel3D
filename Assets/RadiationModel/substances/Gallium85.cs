using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium85";
        public override double halfLife { get; } = 0.092d;
        public override double atomicWeight { get; } = 84.95734d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium85() }, { 1.0d, new BetaParticle(-1, 6691500.0) } } },
            { 0.35d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium85() }, { 1.0d, new BetaParticle(-1, 6691500.0) } } },

        };
    }
}
    