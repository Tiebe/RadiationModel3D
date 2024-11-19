using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold191m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold191m";
        public override double halfLife { get; } = 0.92d;
        public override double atomicWeight { get; } = 190.964d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((266000.0, 0.00466)), new Gold191() } },

        };
    }
}
    
    