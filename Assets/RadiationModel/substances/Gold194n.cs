
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold194n : RadioactiveSubstance
    {
        public override string name { get; } = "Gold194n";
        public override double halfLife { get; } = 0.42d;
        public override double atomicWeight { get; } = 193.96593d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Gold194() } },

        };
    }
}
    
    