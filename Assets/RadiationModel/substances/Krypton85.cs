
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton85 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton85";
        public override double halfLife { get; } = 338542981.056d;
        public override double atomicWeight { get; } = 84.91253d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rubidium85() } },

        };
    }
}
    
    