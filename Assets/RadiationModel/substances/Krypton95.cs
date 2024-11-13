
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton95 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton95";
        public override double halfLife { get; } = 0.114d;
        public override double atomicWeight { get; } = 94.93971d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rubidium95() } },

        };
    }
}
    
    