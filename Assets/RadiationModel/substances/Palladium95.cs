using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium95";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 94.92489d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium95() }, { 1.0d, new BetaParticle(1, 6746000.0) } } },

        };
    }
}
    