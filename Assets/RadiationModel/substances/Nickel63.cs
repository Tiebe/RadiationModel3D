using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel63 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel63";
        public override double halfLife { get; } = 3193563542.4d;
        public override double atomicWeight { get; } = 62.92967d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 67000.0), new Copper63() } },

        };
    }
}
    
    