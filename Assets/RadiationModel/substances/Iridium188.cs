
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium188 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium188";
        public override double halfLife { get; } = 149400.0d;
        public override double atomicWeight { get; } = 187.95883d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Osmium188() } },

        };
    }
}
    
    