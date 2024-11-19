using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold197m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold197m";
        public override double halfLife { get; } = 7.73d;
        public override double atomicWeight { get; } = 196.96701d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00303, 409100.0), new Gold197() } },

        };
    }
}
    
    