using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum136 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum136";
        public override double halfLife { get; } = 592.2d;
        public override double atomicWeight { get; } = 135.90763d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2847080.0), new Barium136() } },

        };
    }
}
    
    