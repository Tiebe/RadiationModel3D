using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium70 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium70";
        public override double halfLife { get; } = 2466.0d;
        public override double atomicWeight { get; } = 69.93352d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2404100.0), new Arsenic70() } },

        };
    }
}
    
    