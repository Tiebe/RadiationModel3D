using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony136 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony136";
        public override double halfLife { get; } = 0.923d;
        public override double atomicWeight { get; } = 135.93075d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9918300.0), new Tellurium136() } },

        };
    }
}
    
    