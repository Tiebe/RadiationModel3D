
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium183 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium183";
        public override double halfLife { get; } = 3480.0d;
        public override double atomicWeight { get; } = 182.95684d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Osmium183() } },

        };
    }
}
    
    