using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium183 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium183";
        public override double halfLife { get; } = 46800.0d;
        public override double atomicWeight { get; } = 182.95313d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2150000.0), new Rhenium183() } },

        };
    }
}
    
    