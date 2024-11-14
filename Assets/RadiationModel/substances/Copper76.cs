using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper76 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper76";
        public override double halfLife { get; } = 0.6377d;
        public override double atomicWeight { get; } = 75.94527d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11321400.0), new Zinc76() } },

        };
    }
}
    
    