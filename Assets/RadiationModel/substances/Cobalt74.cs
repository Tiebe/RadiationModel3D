
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt74 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt74";
        public override double halfLife { get; } = 0.0313d;
        public override double atomicWeight { get; } = 73.96399d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Nickel74() } },

        };
    }
}
    
    