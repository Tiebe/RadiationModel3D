using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium69 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium69";
        public override double halfLife { get; } = 27.4d;
        public override double atomicWeight { get; } = 68.93941d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6675300.0), new Arsenic69() } },

        };
    }
}
    
    