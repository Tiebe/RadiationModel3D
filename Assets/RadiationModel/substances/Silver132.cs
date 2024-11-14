using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver132 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver132";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 131.96307d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 16070000.0), new Cadmium132() } },

        };
    }
}
    
    