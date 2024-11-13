
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron72 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron72";
        public override double halfLife { get; } = 0.017d;
        public override double atomicWeight { get; } = 71.9686d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt72() } },

        };
    }
}
    
    