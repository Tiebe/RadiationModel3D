using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium131";
        public override double halfLife { get; } = 0.0178d;
        public override double atomicWeight { get; } = 130.95764d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium130() }, { 1.0d, new ProtonParticle() } } },
            { 0.11d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Promethium131() }, { 1.0d, new BetaParticle(1, 10155000.0) } } },

        };
    }
}
    