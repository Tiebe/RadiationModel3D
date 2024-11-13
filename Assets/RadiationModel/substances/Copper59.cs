
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper59 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper59";
        public override double halfLife { get; } = 81.5d;
        public override double atomicWeight { get; } = 58.9395d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Nickel59() } },

        };
    }
}
    
    