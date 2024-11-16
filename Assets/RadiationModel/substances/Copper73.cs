using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper73 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper73";
        public override double halfLife { get; } = 4.2d;
        public override double atomicWeight { get; } = 72.93667d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6606000.0), new Zinc73() } },

        };
    }
}
    
    