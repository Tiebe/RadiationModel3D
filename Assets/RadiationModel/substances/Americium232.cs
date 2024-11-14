using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium232";
        public override double halfLife { get; } = 78.6d;
        public override double atomicWeight { get; } = 232.04661d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.97d, new List<RadioactiveSubstance> { new BetaParticle(1, 5059000.0), new Plutonium232() } },

        };
    }
}
    
    