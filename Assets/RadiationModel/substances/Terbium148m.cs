using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium148m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium148m";
        public override double halfLife { get; } = 132.0d;
        public override double atomicWeight { get; } = 147.92437d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5822400.0), new Gadolinium148() } },

        };
    }
}
    
    