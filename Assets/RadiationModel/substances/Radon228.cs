
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon228 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon228";
        public override double halfLife { get; } = 65.0d;
        public override double atomicWeight { get; } = 228.03783d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Francium228() } },

        };
    }
}
    
    