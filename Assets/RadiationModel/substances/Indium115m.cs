using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium115m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium115m";
        public override double halfLife { get; } = 16149.6d;
        public override double atomicWeight { get; } = 114.90424d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.95d, new List<RadioactiveSubstance> { new GammaParticle(0.00369), new Indium115() } },
            { 0.05d, new List<RadioactiveSubstance> { new BetaParticle(-1, 833733.0), new Tin115() } },

        };
    }
}
    
    