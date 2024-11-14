using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton89 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton89";
        public override double halfLife { get; } = 189.0d;
        public override double atomicWeight { get; } = 88.91784d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5176200.0), new Rubidium89() } },

        };
    }
}
    
    