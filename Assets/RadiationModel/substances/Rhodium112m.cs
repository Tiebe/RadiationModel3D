using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium112m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium112m";
        public override double halfLife { get; } = 6.73d;
        public override double atomicWeight { get; } = 111.91477d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6931000.0), new Palladium112() } },

        };
    }
}
    
    