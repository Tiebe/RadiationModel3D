using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium153";
        public override double halfLife { get; } = 31.6d;
        public override double atomicWeight { get; } = 152.92772d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3317600.0), new Promethium153() } },

        };
    }
}
    
    