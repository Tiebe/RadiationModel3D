using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium108";
        public override double halfLife { get; } = 16.8d;
        public override double atomicWeight { get; } = 107.90872d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4493200.0), new Palladium108() } },

        };
    }
}
    
    