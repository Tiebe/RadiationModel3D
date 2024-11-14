using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium26 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium26";
        public override double halfLife { get; } = 1.07128d;
        public override double atomicWeight { get; } = 25.99263d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9353544.0), new Magnesium26() } },

        };
    }
}
    
    