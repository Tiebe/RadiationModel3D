using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt64 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt64";
        public override double halfLife { get; } = 0.3d;
        public override double atomicWeight { get; } = 63.93581d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7307000.0), new Nickel64() } },

        };
    }
}
    
    