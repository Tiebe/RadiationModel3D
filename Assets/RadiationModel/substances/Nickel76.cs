using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel76 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel76";
        public override double halfLife { get; } = 0.2346d;
        public override double atomicWeight { get; } = 75.95471d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8791600.0), new Copper76() } },

        };
    }
}
    
    