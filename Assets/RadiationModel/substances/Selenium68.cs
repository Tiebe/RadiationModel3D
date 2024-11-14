using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium68 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium68";
        public override double halfLife { get; } = 35.5d;
        public override double atomicWeight { get; } = 67.94183d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4705100.0), new Arsenic68() } },

        };
    }
}
    
    