using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium142";
        public override double halfLife { get; } = 636.0d;
        public override double atomicWeight { get; } = 141.91643d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2182000.0), new Lanthanum142() } },

        };
    }
}
    
    