
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony141 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony141";
        public override double halfLife { get; } = 0.103d;
        public override double atomicWeight { get; } = 140.95755d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tellurium141() } },

        };
    }
}
    
    