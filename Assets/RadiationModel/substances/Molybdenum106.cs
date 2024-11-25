using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum106 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum106";
        public override double halfLife { get; } = 8.73d;
        public override double atomicWeight { get; } = 105.91827d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium106() }, { 1.0d, new BetaParticle(-1, 1824000.0) } } },

        };
    }
}
    