using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium159";
        public override double halfLife { get; } = 1.634d;
        public override double atomicWeight { get; } = 158.93929d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium159() }, { 1.0d, new BetaParticle(-1, 2827000.0) } } },
            { 0.006d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium159() }, { 1.0d, new BetaParticle(-1, 2827000.0) } } },

        };
    }
}
    