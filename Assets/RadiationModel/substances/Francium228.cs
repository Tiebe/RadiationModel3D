
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium228 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium228";
        public override double halfLife { get; } = 38.0d;
        public override double atomicWeight { get; } = 228.03584d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Radium228() } },

        };
    }
}
    
    