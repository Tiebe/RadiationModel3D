
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium120";
        public override double halfLife { get; } = 0.492d;
        public override double atomicWeight { get; } = 119.92455d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver120() } },

        };
    }
}
    
    