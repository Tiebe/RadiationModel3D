using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton90 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton90";
        public override double halfLife { get; } = 32.32d;
        public override double atomicWeight { get; } = 89.91953d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4406700.0), new Rubidium90() } },

        };
    }
}
    
    