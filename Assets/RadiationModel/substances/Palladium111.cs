
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium111";
        public override double halfLife { get; } = 1413.6d;
        public override double atomicWeight { get; } = 110.90769d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver111() } },

        };
    }
}
    
    