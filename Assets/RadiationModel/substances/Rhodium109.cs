using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium109 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium109";
        public override double halfLife { get; } = 80.8d;
        public override double atomicWeight { get; } = 108.90875d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2607500.0), new Palladium109() } },

        };
    }
}
    
    