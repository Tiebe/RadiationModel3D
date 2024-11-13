
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel75 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel75";
        public override double halfLife { get; } = 0.3316d;
        public override double atomicWeight { get; } = 74.95251d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Copper75() } },

        };
    }
}
    
    