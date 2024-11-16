using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium240";
        public override double halfLife { get; } = 182880.0d;
        public override double atomicWeight { get; } = 240.0553d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1384700.0), new Plutonium240() } },
            { 1.9e-06d, new List<RadioactiveSubstance> { new AlphaParticle(6727002.09), new Neptunium236() } },

        };
    }
}
    
    