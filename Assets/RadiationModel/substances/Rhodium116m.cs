using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium116m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium116m";
        public override double halfLife { get; } = 0.57d;
        public override double atomicWeight { get; } = 115.92427d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9291000.0), new Palladium116() } },

        };
    }
}
    
    