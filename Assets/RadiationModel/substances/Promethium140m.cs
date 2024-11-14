using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium140m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium140m";
        public override double halfLife { get; } = 357.0d;
        public override double atomicWeight { get; } = 139.9165d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6474000.0), new Neodymium140() } },

        };
    }
}
    
    