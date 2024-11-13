
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt75 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt75";
        public override double halfLife { get; } = 0.0265d;
        public override double atomicWeight { get; } = 74.96719d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Nickel75() } },

        };
    }
}
    
    