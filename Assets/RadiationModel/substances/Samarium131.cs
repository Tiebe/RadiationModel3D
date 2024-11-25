using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium131";
        public override double halfLife { get; } = 1.2d;
        public override double atomicWeight { get; } = 130.94602d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium131() }, { 1.0d, new BetaParticle(1, 8744000.0) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium130() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    