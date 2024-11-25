using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium131";
        public override double halfLife { get; } = 618.0d;
        public override double atomicWeight { get; } = 130.91443d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium131() }, { 1.0d, new BetaParticle(1, 3484500.0) } } },
            { 0.11d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum131() }, { 1.0d, new BetaParticle(1, 2029500.0) } } },

        };
    }
}
    