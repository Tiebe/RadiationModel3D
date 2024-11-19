using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium73m : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium73m";
        public override double halfLife { get; } = 2388.0d;
        public override double atomicWeight { get; } = 72.92678d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.726d, new List<RadioactiveSubstance> { new GammaParticle(0.04769, 26000.0), new Selenium73() } },
            { 0.27399999999999997d, new List<RadioactiveSubstance> { new BetaParticle(1, 2752000.0), new Arsenic73() } },

        };
    }
}
    
    