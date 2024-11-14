using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel56 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel56";
        public override double halfLife { get; } = 524880.0d;
        public override double atomicWeight { get; } = 55.94213d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2132900.0), new Cobalt56() } },

        };
    }
}
    
    