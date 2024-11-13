
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium116";
        public override double halfLife { get; } = 0.685d;
        public override double atomicWeight { get; } = 115.92406d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium116() } },

        };
    }
}
    
    