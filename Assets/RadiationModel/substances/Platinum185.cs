using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum185 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum185";
        public override double halfLife { get; } = 4254.0d;
        public override double atomicWeight { get; } = 184.96061d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium185() }, { 1.0d, new BetaParticle(1, 3058950.0) } } },

        };
    }
}
    