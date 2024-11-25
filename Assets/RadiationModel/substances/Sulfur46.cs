using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur46 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur46";
        public override double halfLife { get; } = 0.05d;
        public override double atomicWeight { get; } = 46.00069d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine46() }, { 1.0d, new BetaParticle(-1, 7185000.0) } } },

        };
    }
}
    