using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium207 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium207";
        public override double halfLife { get; } = 0.031d;
        public override double atomicWeight { get; } = 207.01197d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8871002.09), new Francium203() } },

        };
    }
}
    
    