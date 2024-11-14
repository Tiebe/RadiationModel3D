using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc80 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc80";
        public override double halfLife { get; } = 0.5622d;
        public override double atomicWeight { get; } = 79.94455d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7575100.0), new Gallium80() } },

        };
    }
}
    
    