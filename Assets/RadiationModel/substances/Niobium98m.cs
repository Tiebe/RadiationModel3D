
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium98m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium98m";
        public override double halfLife { get; } = 3066.0d;
        public override double atomicWeight { get; } = 97.91042d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum98() } },

        };
    }
}
    
    