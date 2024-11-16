using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium227 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium227";
        public override double halfLife { get; } = 687057958.944d;
        public override double atomicWeight { get; } = 227.02775d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9862000000000001d, new List<RadioactiveSubstance> { new BetaParticle(-1, 44700.0), new Thorium227() } },
            { 0.0138d, new List<RadioactiveSubstance> { new AlphaParticle(6064202.09), new Francium223() } },

        };
    }
}
    
    