
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt53 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt53";
        public override double halfLife { get; } = 0.2446d;
        public override double atomicWeight { get; } = 52.9542d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iron53() } },

        };
    }
}
    
    