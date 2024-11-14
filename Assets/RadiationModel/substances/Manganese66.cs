using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese66 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese66";
        public override double halfLife { get; } = 0.0638d;
        public override double atomicWeight { get; } = 65.96055d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13318000.0), new Iron66() } },

        };
    }
}
    
    