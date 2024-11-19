using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold196m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold196m";
        public override double halfLife { get; } = 8.1d;
        public override double atomicWeight { get; } = 195.96666d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((84699.99999, 0.01464)), new Gold196() } },

        };
    }
}
    
    