using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium175";
        public override double halfLife { get; } = 84.0d;
        public override double atomicWeight { get; } = 174.95695d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5183000.0), new Rhenium175() } },

        };
    }
}
    
    