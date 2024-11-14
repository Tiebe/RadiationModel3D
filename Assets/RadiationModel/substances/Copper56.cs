using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper56 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper56";
        public override double halfLife { get; } = 0.0808d;
        public override double atomicWeight { get; } = 55.95853d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 15277600.0), new Nickel56() } },

        };
    }
}
    
    