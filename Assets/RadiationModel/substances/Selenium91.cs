using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium91";
        public override double halfLife { get; } = 0.27d;
        public override double atomicWeight { get; } = 90.9457d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10527000.0), new Bromine91() } },

        };
    }
}
    
    