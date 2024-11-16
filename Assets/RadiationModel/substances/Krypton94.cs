using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton94 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton94";
        public override double halfLife { get; } = 0.212d;
        public override double atomicWeight { get; } = 93.93414d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7214800.0), new Rubidium94() } },

        };
    }
}
    
    