using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony129 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony129";
        public override double halfLife { get; } = 15717.6d;
        public override double atomicWeight { get; } = 128.90915d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2375900.0), new Tellurium129() } },

        };
    }
}
    
    