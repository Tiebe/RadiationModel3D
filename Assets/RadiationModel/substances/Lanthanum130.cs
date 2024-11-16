using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum130 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum130";
        public override double halfLife { get; } = 522.0d;
        public override double atomicWeight { get; } = 129.91237d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5629780.0), new Barium130() } },

        };
    }
}
    
    