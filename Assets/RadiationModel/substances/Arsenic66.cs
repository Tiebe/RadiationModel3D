using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic66 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic66";
        public override double halfLife { get; } = 0.09577d;
        public override double atomicWeight { get; } = 65.94415d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium66() }, { 1.0d, new BetaParticle(1, 5849350.0) } } },

        };
    }
}
    