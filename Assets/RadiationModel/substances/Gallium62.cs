using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium62 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium62";
        public override double halfLife { get; } = 0.11612d;
        public override double atomicWeight { get; } = 61.94419d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9181100.0), new Zinc62() } },

        };
    }
}
    
    