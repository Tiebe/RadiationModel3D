
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium33 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium33";
        public override double halfLife { get; } = 0.0082d;
        public override double atomicWeight { get; } = 33.02553d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Magnesium33() } },

        };
    }
}
    
    