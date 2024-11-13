
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium144";
        public override double halfLife { get; } = 0.7d;
        public override double atomicWeight { get; } = 143.95211d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium144() } },

        };
    }
}
    
    