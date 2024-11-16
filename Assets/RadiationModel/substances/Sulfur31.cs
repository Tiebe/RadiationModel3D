using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur31 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur31";
        public override double halfLife { get; } = 2.5534d;
        public override double atomicWeight { get; } = 30.97956d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5398014.4), new Phosphorus31() } },

        };
    }
}
    
    