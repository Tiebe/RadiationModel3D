using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium240";
        public override double halfLife { get; } = 3714.0d;
        public override double atomicWeight { get; } = 240.05616d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2190700.0), new Plutonium240() } },

        };
    }
}
    
    