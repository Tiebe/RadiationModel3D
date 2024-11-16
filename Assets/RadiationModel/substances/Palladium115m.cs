using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium115m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium115m";
        public override double halfLife { get; } = 50.0d;
        public override double atomicWeight { get; } = 114.91375d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.92d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4646000.0), new Silver115() } },
            { 0.08d, new List<RadioactiveSubstance> { new GammaParticle((89000.0, 0.01393)), new Palladium115() } },

        };
    }
}
    
    