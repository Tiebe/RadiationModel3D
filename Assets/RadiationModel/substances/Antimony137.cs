using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony137 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony137";
        public override double halfLife { get; } = 0.45d;
        public override double atomicWeight { get; } = 136.93552d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium137() }, { 1.0d, new BetaParticle(-1, 4621900.0) } } },
            { 0.49d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium137() }, { 1.0d, new BetaParticle(-1, 4621900.0) } } },

        };
    }
}
    