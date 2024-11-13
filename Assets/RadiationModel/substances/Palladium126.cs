
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium126 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium126";
        public override double halfLife { get; } = 0.0486d;
        public override double atomicWeight { get; } = 125.9444d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver126() } },

        };
    }
}
    
    