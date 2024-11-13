
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium214";
        public override double halfLife { get; } = 11.0d;
        public override double atomicWeight { get; } = 214.00695d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lead214() } },

        };
    }
}
    
    