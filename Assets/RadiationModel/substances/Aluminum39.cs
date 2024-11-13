
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum39 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum39";
        public override double halfLife { get; } = 0.0076d;
        public override double atomicWeight { get; } = 39.02307d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silicon39() } },

        };
    }
}
    
    