using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth217 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth217";
        public override double halfLife { get; } = 98.5d;
        public override double atomicWeight { get; } = 217.00937d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2847000.0), new Polonium217() } },

        };
    }
}
    
    