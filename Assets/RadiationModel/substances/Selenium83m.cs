using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium83m : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium83m";
        public override double halfLife { get; } = 70.1d;
        public override double atomicWeight { get; } = 82.91936d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3902000.0), new Bromine83() } },

        };
    }
}
    
    