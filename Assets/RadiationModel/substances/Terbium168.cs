
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium168";
        public override double halfLife { get; } = 9.4d;
        public override double atomicWeight { get; } = 167.94334d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium168() } },

        };
    }
}
    
    