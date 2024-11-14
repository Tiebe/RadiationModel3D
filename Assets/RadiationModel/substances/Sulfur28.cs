using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur28 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur28";
        public override double halfLife { get; } = 0.125d;
        public override double atomicWeight { get; } = 28.00437d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11217900.0), new Phosphorus28() } },

        };
    }
}
    
    