using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum88 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum88";
        public override double halfLife { get; } = 480.0d;
        public override double atomicWeight { get; } = 87.92197d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium88() }, { 1.0d, new BetaParticle(1, 5471000.0) } } },

        };
    }
}
    