
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium126 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium126";
        public override double halfLife { get; } = 0.019d;
        public override double atomicWeight { get; } = 125.96006d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium126() } },

        };
    }
}
    
    