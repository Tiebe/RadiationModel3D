using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium54 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium54";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 53.95089d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium54() }, { 1.0d, new BetaParticle(-1, 2077000.0) } } },

        };
    }
}
    