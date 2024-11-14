using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium120";
        public override double halfLife { get; } = 0.1296d;
        public override double atomicWeight { get; } = 119.93707d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11659600.0), new Palladium120() } },

        };
    }
}
    
    