using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium237";
        public override double halfLife { get; } = 4416.0d;
        public override double atomicWeight { get; } = 237.04999d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9997499999999999d, new List<RadioactiveSubstance> { new BetaParticle(1, 1478300.0), new Plutonium237() } },
            { 0.00025d, new List<RadioactiveSubstance> { new AlphaParticle(7215047.4), new Neptunium233() } },

        };
    }
}
    
    