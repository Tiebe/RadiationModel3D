using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic88 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic88";
        public override double halfLife { get; } = 0.27d;
        public override double atomicWeight { get; } = 87.94584d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13434000.0), new Selenium88() } },

        };
    }
}
    
    