
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt51 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt51";
        public override double halfLife { get; } = 0.0688d;
        public override double atomicWeight { get; } = 50.97065d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iron51() } },

        };
    }
}
    
    