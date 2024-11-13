
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum25 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum25";
        public override double halfLife { get; } = 7.1666d;
        public override double atomicWeight { get; } = 24.99043d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Magnesium25() } },

        };
    }
}
    
    