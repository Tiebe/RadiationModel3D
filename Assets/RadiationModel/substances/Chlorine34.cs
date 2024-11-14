using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine34 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine34";
        public override double halfLife { get; } = 1.5267d;
        public override double atomicWeight { get; } = 33.97376d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5491600.0), new Sulfur34() } },

        };
    }
}
    
    