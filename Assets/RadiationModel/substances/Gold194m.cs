using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold194m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold194m";
        public override double halfLife { get; } = 0.6d;
        public override double atomicWeight { get; } = 193.96553d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01154), new Gold194() } },

        };
    }
}
    
    