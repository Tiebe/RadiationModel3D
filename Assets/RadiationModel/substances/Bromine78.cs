using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine78 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine78";
        public override double halfLife { get; } = 387.0d;
        public override double atomicWeight { get; } = 77.92115d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3573950.0), new Selenium78() } },
            { 0.0001d, new List<RadioactiveSubstance> { new BetaParticle(-1, 726300.0), new Krypton78() } },

        };
    }
}
    
    