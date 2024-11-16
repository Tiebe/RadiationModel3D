using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium237";
        public override double halfLife { get; } = 522.0d;
        public override double atomicWeight { get; } = 237.05102d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2137900.0), new Uranium237() } },

        };
    }
}
    
    