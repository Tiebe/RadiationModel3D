
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron66 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron66";
        public override double halfLife { get; } = 0.467d;
        public override double atomicWeight { get; } = 65.94625d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt66() } },

        };
    }
}
    
    