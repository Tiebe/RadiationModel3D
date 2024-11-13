
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium91";
        public override double halfLife { get; } = 0.032d;
        public override double atomicWeight { get; } = 90.95043d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhodium91() } },

        };
    }
}
    
    