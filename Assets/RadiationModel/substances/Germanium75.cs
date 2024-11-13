
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium75 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium75";
        public override double halfLife { get; } = 4966.8d;
        public override double atomicWeight { get; } = 74.92286d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Arsenic75() } },

        };
    }
}
    
    