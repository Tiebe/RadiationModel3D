using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine41 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine41";
        public override double halfLife { get; } = 38.4d;
        public override double atomicWeight { get; } = 40.97068d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5757500.0), new Argon41() } },

        };
    }
}
    
    