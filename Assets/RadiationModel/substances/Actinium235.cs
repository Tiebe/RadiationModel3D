using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium235";
        public override double halfLife { get; } = 62.0d;
        public override double atomicWeight { get; } = 235.05084d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3339000.0), new Thorium235() } },

        };
    }
}
    
    