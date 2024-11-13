
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium116";
        public override double halfLife { get; } = 11.8d;
        public override double atomicWeight { get; } = 115.9143d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver116() } },

        };
    }
}
    
    