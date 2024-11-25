using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium59 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium59";
        public override double halfLife { get; } = 0.0285d;
        public override double atomicWeight { get; } = 58.97222d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium59() }, { 1.0d, new BetaParticle(-1, 5865000.0) } } },

        };
    }
}
    