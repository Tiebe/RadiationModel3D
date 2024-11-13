
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium98";
        public override double halfLife { get; } = 132539198400000.0d;
        public override double atomicWeight { get; } = 97.90721d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium98() } },

            { 0.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum98() } },

        };
    }
}
    
    