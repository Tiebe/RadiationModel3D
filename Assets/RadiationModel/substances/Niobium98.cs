
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium98";
        public override double halfLife { get; } = 2.86d;
        public override double atomicWeight { get; } = 97.91033d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum98() } },

        };
    }
}
    
    